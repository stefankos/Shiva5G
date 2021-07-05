select  sa.projectno AS PROJECTNO,
SUBSTR(sa.IDNAME, 1, 20) AS SiteID,
ln.NAME AS SiteName, 
CAST ((CASE WHEN la.INHERITMASTERPATTERN = 0 THEN ap.DOWNTILT
WHEN la.INHERITMASTERPATTERN = 1 THEN ap1.DOWNTILT
WHEN la.INHERITMASTERPATTERN = 2 THEN ap2.DOWNTILT
WHEN la.INHERITMASTERPATTERN = 3 THEN ap3.DOWNTILT
WHEN la.INHERITMASTERPATTERN = 4 THEN ap4.DOWNTILT
END) AS DECIMAL(15,10)) AS Etilt,
fram.IDNAME DUPLEXMODE,
freq.freqbandname FREQBAND,
fram.DLBANDWIDTH DLBANDWIDTH,
 (CASE WHEN fram.dlnumerology = 0 THEN 'subcarrier_spacing:15hz'
WHEN fram.dlnumerology = 1 THEN 'subcarrier_spacing:30hz'
 WHEN fram.dlnumerology = 2 THEN 'subcarrier_spacing:60hz'
END) AS subcarrier_spacing,
sa.ADDRESS1 AS SiteAddress1,
sa.ADDRESS2 AS SiteAddress2,
antdev.IDNAME AS AntennaType,
CAST (pa.PHYINDEX AS DECIMAL(15,10)) AS PHYIndex,
CAST (pa.AZIMUTH AS DECIMAL(15,10)) AS Azimuth,
CAST (pa.HEIGHT AS DECIMAL(15,10)) AS HEIGHT,
CAST (pa.HEIGHTOFFSET AS DECIMAL(15,10)) AS HEIGHTOFFSET,
CAST (pa.TILT AS DECIMAL(15,10)) AS MechanicalTilt,
CAST (lf.FEEDERLEN AS DECIMAL(15,10)) AS FeederLength,
f.IDNAME AS FeederType,
lc.IDNAME AS CellName,
fcell.secname SECTOR,
fc.MAXTXPOWER AS MAXTXPOWER,
fcarrier.idname Band,
(SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = ln.LOGNODEPK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'Candidate')AS Candidate,
 (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = fcell.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'RRU type')AS RRUType,
(SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = fcell.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'TMA')AS TMA,

                      (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = fcell.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'Combiner/Splitter')AS CombinerSplitter,
                      (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = ln.LOGNODEPK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'Co-Location')AS CoLocation,
                      (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = fcell.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'Antenna Mounting')AS AntennaMount,
CAST (fcell.CELLID AS DECIMAL(20,10)) AS CellID	
FROM SITEADDRESS sa
JOIN LOGNODE ln ON sa.ADDRESSKEY = ln.ADDRESSFK AND ln.PROJECTNO = 1
JOIN LOGCELL lc ON lc.LOGNODEFK = ln.LOGNODEPK  AND ln.LOGNODETYPEFK=LC.LOGNODETYPEFK AND lc.PROJECTNO = 1	
JOIN FIVEGCELLPARAMS fcell ON fcell.LOGCELLFK = lc.LOGCELLPK  AND fcell.PROJECTNO = 1	
JOIN FIVEGCELLCAR fc ON lc.logcellpk=fc.LOGCELLFK  AND fc.PROJECTNO = 1
JOIN LOGCELLFEEDER lf ON  fcell.LOGCELLFK=lf.logcellfk  AND lf.PROJECTNO = 1
JOIN FEEDER f ON lf.FEEDERFK=f.FEEDERKEY
JOIN LOGICALANTENNA la ON la.LOGANTENNAPK=lf.LOGANTENNAFK AND la.PROJECTNO = 1
JOIN PHYANTENNA pa ON pa.PHYANTENNAPK=la.PHYANTENNAFK AND pa.PROJECTNO = 1
JOIN ANTENNADEVICE antdev ON pa.DEVICEFK=antdev.DEVICEPK AND antdev.PROJECTNO = 1	 
JOIN ANTENNAPATTERN ap ON la.anttypefk = ap.PATTERNPK AND ap.PROJECTNO = 1
JOIN ANTENNAPATTERN ap1 ON ap1.PATTERNPK = pa.MASTERPATTERN1FK AND ap1.PROJECTNO = 1
JOIN ANTENNAPATTERN ap2 ON ap2.PATTERNPK = pa.MASTERPATTERN2FK AND ap2.PROJECTNO = 1
JOIN ANTENNAPATTERN ap3 ON ap3.PATTERNPK = pa.MASTERPATTERN3FK AND ap3.PROJECTNO = 1
JOIN ANTENNAPATTERN ap4 ON ap4.PATTERNPK = pa.MASTERPATTERN4FK AND ap4.PROJECTNO = 1
JOIN ANTENNADEVICE antdev ON pa.DEVICEFK=antdev.DEVICEPK AND antdev.PROJECTNO = 1	
JOIN FIVEGNODECAR fnode ON  ln.lognodepk=fnode.LOGNODEFK AND fnode.PROJECTNO = 1	
JOIN MUNODE mu ON  fnode.lognodefk=mu.lognodepk AND mu.PROJECTNO = 1	
JOIN fivegcarrier fcarrier ON fnode.CONFIGCARRIERFK=fcarrier.CARRIERKEY AND fcarrier.PROJECTNO = 1
join FIVEGFRAMES fram on fcarrier.FRAME_STRUCT_FK= fram.FRAME_PK AND fram.PROJECTNO = 1
join FIVEGFREQBANDS freq on fram.freq_band_fk=freq.FREQBANDPK AND freq.PROJECTNO = 1
		
where SUBSTR(sa.IDNAME, 1, 20) like '%SF1145%'