spec_i([ proc,0,'Stub for RPT_Personas','RPT_Personas',80,eng,'15_0_12-126726' ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
rule_i(0,datastore(1,'DS_LAST_CHANGE','')).
rule_i(0,datastore(1,'LOCK_RETRY','10')).
rule_i(0,datastore(1,'WAIT_RECORD','0')).
rule_i(0,datastore(1,'SQLSERVER_VERSION','10')).
rule_i(0,datastore(1,'COMMENT_ON','No')).
rule_i(0,datastore(1,'DFT_TMP_TBLSPACE','')).
rule_i(0,datastore(1,'DFT_IDX_TBLSPACE','')).
rule_i(0,datastore(1,'DFT_TBL_TBLSPACE','')).
rule_i(0,datastore(1,'DCL_REF_INT_DB','Yes')).
rule_i(0,datastore(1,'PRIMARY_KEY_TYPE','PK')).
rule_i(0,datastore(1,'CS_SCHEMA','')).
rule_i(0,datastore(1,'SORT_ATTRIBUTES','Yes')).
rule_i(0,datastore(1,'JRN400','QSQJRN')).
rule_i(0,datastore(1,'CREATE_SAVF','Yes')).
rule_i(0,datastore(1,'PGMLIB','')).
rule_i(0,datastore(1,'DTALIB','')).
rule_i(0,datastore(1,'CC_USER_PASS','�TrRL����F�|cJzK')).
rule_i(0,datastore(1,'CC_USER_ID',uJjLBaz8dD7rSDrK)).
rule_i(0,datastore(1,'CC_SERVER','trialapps3.genexus.com')).
rule_i(0,datastore(1,'CC_DBNAME','Idb044a318d003042937e963463dd07681')).
rule_i(0,datastore(1,'RecycleRWMin','30')).
rule_i(0,datastore(1,'RecycleRWType','1')).
rule_i(0,datastore(1,'RecycleRW','-1')).
rule_i(0,datastore(1,'POOL_STARTUP','No')).
rule_i(0,datastore(1,'POOLSIZE_RW','10')).
rule_i(0,datastore(1,'UnlimitedRWPool','-1')).
rule_i(0,datastore(1,'PoolRWEnabled','-1')).
rule_i(0,datastore(1,'CS_RPCPGML','')).
rule_i(0,datastore(1,'JDBC_DATASOURCE','')).
rule_i(0,datastore(1,'USE_JDBC_DATASOURCE','0')).
rule_i(0,datastore(1,'DS_DBMS_ADDINFO','')).
rule_i(0,datastore(1,'USER_PASSWORD','u�HdT�@ar�BJ�D�Gr[�<Tk')).
rule_i(0,datastore(1,'USER_ID',uJjLBaz8dD7rSDrK)).
rule_i(0,datastore(1,'TRUSTED_CONNECTION','No')).
rule_i(0,datastore(1,'CS_CONNECT','First')).
rule_i(0,datastore(1,'DBMS_PORT','')).
rule_i(0,datastore(1,'CS_SERVER','trialapps3.genexus.com')).
rule_i(0,datastore(1,'CS_DBNAME','Idb044a318d003042937e963463dd07681')).
rule_i(0,datastore(1,'CS_FLEDSNAME','')).
rule_i(0,datastore(1,'CS_DRVNAME','sql server')).
rule_i(0,datastore(1,'CS_DSNAME','')).
rule_i(0,datastore(1,'DB_URL','')).
rule_i(0,datastore(1,'JDBC_CUSTOM_URL','0')).
rule_i(0,datastore(1,'JDBC_CUSTOM_DRIVER','')).
rule_i(0,datastore(1,'JDBC_DRIVER','net.sourceforge.jtds.jdbc.Driver')).
rule_i(0,datastore(1,'CONNECT_METHOD','OPSYS')).
rule_i(0,datastore(1,'ACCESS_TECHNO','ADONET')).
rule_i(0,datastore(1,'MAIN_DS','-1')).
rule_i(0,datastore(1,'REORG_GEN','8')).
rule_i(0,datastore(1,'HelpKeyword','20')).
rule_i(0,datastore(1,'DBMS',12)).
rule_i(0,datastore(1,'NAME','Default')).
rule_i(0,prop(idNULLS_BEHAVIOR,idNB_Current)).
rule_i(0,maingen(15)).
rule_i(0,parm([],[])).
rule_i(0,parmio([])).
rule_i(0,stub(proc)).
 
a_i(1,1,f,'Err',[],[ [],[ t('0',3) ] ]).
 
v_i(f,i,1,[]).
v_i(f,o,1,'Err').
 
 
 
 
 
 
attri_i('Errmsg',[ 'Gx_emsg',char,70,0,'',1,'Error text','',3 ]).
attri_i('Err',[ 'Gx_err',int,3,0,'ZZ9',1,'Error code','',2 ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
break_i(1,rpt,0,[],[ [],[],[] ]).
 
b_group_i(1,1,lit,0,1,0).
 
b_line_i(1,1,1,cmd,1,[ t('',163,1,0),t('ARPT_Personas',3,1,0),t(15,3,1,0),t('',3,1,0),t(',',7,1,0),t(')',4,1,0) ]).
 
 
 
 
 
 
page_layout_i([ 66,0,6 ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
calling_main_i(1,10).
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
pgm_parm_i(proc,10,'ARPT_PERSONAS',[],[]).
 
pgm_callprotocol_i(proc,0,'RPT_PERSONAS','INTERNAL').
pgm_callprotocol_i(proc,10,'ARPT_PERSONAS','HTTP').
 
 
pgm_main_info_i(proc,10,'RPT_PERSONAS',[ 15,'ARPT_PERSONAS','RPT_Personas','','','','HTTP' ]).
 
 
 
 
 
 
 
 
 
 
 
 
