spec_i([ proc,0,'Load redundancy procedure','GXLRED',80,eng,'15_0_12-126726' ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
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
rule_i(0,datastore(1,'CC_USER_PASS',…„S†l‹’kƒÂ¸Vj»ee)).
rule_i(0,datastore(1,'CC_USER_ID',uzKpbkjkc86Th3EU)).
rule_i(0,datastore(1,'CC_SERVER','trialapps3.genexus.com')).
rule_i(0,datastore(1,'CC_DBNAME','Id3b1d29a52eee074d2c890ee7a2f43a18')).
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
rule_i(0,datastore(1,'USER_PASSWORD','uzÚCpZsR‹KÌ8Ô:rfÜ3Ú9E')).
rule_i(0,datastore(1,'USER_ID',uzKpbkjkc86Th3EU)).
rule_i(0,datastore(1,'TRUSTED_CONNECTION','No')).
rule_i(0,datastore(1,'CS_CONNECT','First')).
rule_i(0,datastore(1,'DBMS_PORT','')).
rule_i(0,datastore(1,'CS_SERVER','trialapps3.genexus.com')).
rule_i(0,datastore(1,'CS_DBNAME','Id3b1d29a52eee074d2c890ee7a2f43a18')).
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
 
a_i(1,1,f,'Err',[],[ [],[ t('0',3) ] ]).
 
v_i(f,i,1,[]).
v_i(f,o,1,'Err').
 
 
 
 
 
 
attri_i('Errmsg',[ 'Gx_emsg',char,70,0,'',1,'Error text','',3 ]).
attri_i('Err',[ 'Gx_err',int,3,0,'ZZ9',1,'Error code','',2 ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
break_i(1,rpt,0,[],[ [],[],[] ]).
 
b_group_i(1,1,lit,0,1,0).
 
b_line_i(1,1,1,cmd,1,[ t('',105,1,0) ]).
 
 
 
 
 
 
page_layout_i([ 66,0,6 ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
gen_reo_i.
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
pgm_callprotocol_i(proc,0,'GXLRED','INTERNAL').
 
 
 
 
 
 
 
 
 
 
 
 
 
 
