  select  
                        a.cellid as CellID, b4.idname as CellName,la.INDEXNO as LOGINDEX,	
                        substr(b4.IDNAME,5, 1) as Sector	,
                        b5.idname as SiteID,
                        substr(h.IDNAME,11, 1) as Candidate,
                        h.TOWN as SiteAddress,
                        h.ADDRESS1 as SiteAddress1,
                        h.ADDRESS2 as SiteAddress2,
                        b5.NAME as SiteName,
                        0 as GSM_TRX,
                        0 as GSM_Pwr_per_TRX ,
                        0 as UMTS_TRX ,
                        0 as UMTS_Pwr_per_TRX,
                        1 as LTE_TRX,
                        a1.REFERENCESIGNALPPRE as LTE_Pwr_per_TRX ,
                        0 as NR_TRX ,
                        0 as NR_Pwr_per_TRX,
                       'L' as LAYER_TECHNOLOGY,
                        ' ' as Controler,

                        CASE 
                        WHEN a3.IDNAME like  '%900%'  THEN '900' 
                        WHEN a3.IDNAME like  '%1800%'  THEN '1800' 
                        WHEN a3.IDNAME like  '%2100%'  THEN '2100' 
                        ELSE '2600'
                        END as Band,

                        pa.PHYINDEX as PHYINDEX,
                        pa.AZIMUTH as Azimuth,
                        pa.HEIGHT as AGL,
                        pa.HEIGHTOFFSET as ARTL,
                        ad.IDNAME as AntennaType,
                        f.FEEDERLEN as FEEDERLENGTH,
                        fe.IDNAME as FEEDERTYPE,
                        pa.TILT as MECHANICAL_TILT,

                        CASE WHEN la.INHERITMASTERPATTERN=0 THEN ap.downtilt
                        WHEN la.INHERITMASTERPATTERN=1 THEN ap1.downtilt 
                        WHEN la.INHERITMASTERPATTERN=2 THEN ap2.downtilt
                        WHEN la.INHERITMASTERPATTERN=3 THEN ap3.downtilt
                        WHEN la.INHERITMASTERPATTERN=4 THEN ap4.downtilt
                        END AS Etilt, 
                        
                        la.PORTS as PortNumber,

                        (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = a.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'RRU type') AS RRU_Type,

                        (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = a.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'TMA') AS TMA,

                        (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = a.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'Combiner/Splitter') AS COMBINER_SPLITTER,

                        (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = a.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = '2nd Combiner') AS SEC_COMBINER_SPLITTER,

                        (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = b5.LOGNODEPK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'Co-Location') AS CoLocation,

                        (SELECT flg.FLAGID 
                        FROM FLAGS flg
                        JOIN FLAGVALUES flgv ON flgv.OBJECTKEY = a.LOGCELLFK AND flg.FLAGKEY = flgv.FLAGKEY AND flgv.PROJECTNO = 1
                        JOIN FLAGGROUPS flgg ON flgg.FLAGGROUPKEY = flgv.FLAGGROUPKEY AND flgg.PROJECTNO = 1
                        WHERE flgg.FLAGGROUPID = 'Antenna Mounting') AS ANTENNA_MOUNT

from LOGLTECELL a       
                        INNER JOIN LogLteCellCar a1 ON a1.PROJECTNO =a.PROJECTNO AND a1.logcellfk = a.LOGCELLFK    
                        INNER JOIN LOGLTECAR a2 ON a1.PROJECTNO =a2.PROJECTNO AND a1.CARRIERFK = a2.CARRIERPK    
                        INNER JOIN LTECARRIER a3 ON a2.PROJECTNO =a3.PROJECTNO AND a2.LTECARRIERFK = a3.CARRIERKEY    
                        INNER JOIN logcell b4 ON b4.PROJECTNO =a.PROJECTNO AND b4.LOGCELLPK = a.LOGCELLFK   
                        INNER JOIN LOGNODE b5 ON b4.PROJECTNO = b5.PROJECTNO AND b4.LOGNODEFK = b5.LOGNODEPK
                        INNER JOIN network_planning.SITEADDRESS h ON b5.projectno = h.projectno AND b5.addressfk = h.addresskey
                        INNER JOIN network_planning.LOGcellFEEDER f ON a.PROJECTNO = f.projectno AND a.LOGCELLFK = f.LOGCELLFK 
                        INNER JOIN network_planning.FEEDER fe on f.FEEDERFK = fe.FEEDERKEY
                        INNER JOIN logicalantenna la on la.PROJECTno=f.PROJECTno and la.LOGANTENNAPK =f.LOGANTENNAfK
                        INNER JOIN phyantenna pa on pa.PROJECTNO = la.PROJECTNO and pa.PHYANTENNAPK = la.PHYANTENNAFK
                        INNER JOIN  ANTENNAPATTERN ap  on ap.PROJECTNO = la.PROJECTNO and la.anttypefk = ap.patternpk 
                        INNER JOIN ANTENNAPATTERN ap1 on ap1.PROJECTNO = pa.PROJECTNO and ap1.PATTERNPK = pa.MASTERPATTERN1FK
                        INNER JOIN ANTENNAPATTERN ap2 on ap2.PROJECTNO = pa.PROJECTNO and ap2.PATTERNPK = pa.MASTERPATTERN2FK
                        INNER JOIN ANTENNAPATTERN ap3 on ap3.PROJECTNO = pa.PROJECTNO and ap3.PATTERNPK = pa.MASTERPATTERN3FK
                        INNER JOIN ANTENNAPATTERN ap4 on ap4.PROJECTNO = pa.PROJECTNO and ap4.PATTERNPK = pa.MASTERPATTERN4FK
                        INNER JOIN antennaDevice ad on ad.PROJECTNO = pa.PROJECTNO and ad.DEVICEPK = pa.DEVICEFK
                        INNER JOIN network_planning.FLAGVALUES z ON b5.projectno = z.projectno AND b5.lognodepk = z.objectkey 
                        INNER JOIN network_planning.FLAGS y ON y.PROJECTNO = z.PROJECTNO AND y.FLAGGROUPKEY = z.FLAGGROUPKEY AND y.FLAGKEY = z.FLAGKEY 
                        INNER JOIN network_planning.FLAGGROUPS x ON x.PROJECTNO = y.PROJECTNO AND x.FLAGGROUPKEY = y.FLAGGROUPKEY
                        INNER JOIN network_planning.FLAGVALUES z1 ON b4.projectno = z1.projectno AND b4.logcellpk = z1.objectkey 
                        INNER JOIN network_planning.FLAGS y1 ON y1.PROJECTNO = z.PROJECTNO AND y1.FLAGGROUPKEY = z1.FLAGGROUPKEY AND y1.FLAGKEY = z1.FLAGKEY 
                        INNER JOIN network_planning.FLAGGROUPS x1 ON x1.PROJECTNO = y1.PROJECTNO AND x1.FLAGGROUPKEY = y1.FLAGGROUPKEY

where 
                        (x.flaggroupid = 'Candidate')  AND (y.flagid ='Accepted') 
                        AND (x1.flaggroupid = 'Site Progress') AND (y1.flagid ='On Air') 
                        AND (a1.PROJECTNO = 1) 
                        and b5.idname like '%@@@@@@%'
                        