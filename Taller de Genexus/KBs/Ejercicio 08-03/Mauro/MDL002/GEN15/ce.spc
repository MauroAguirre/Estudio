spec_i([ ce,0,'Table Manager',1,2,reo ]).
 
 
ren_i(5,[ 'Cliente1','Cliente' ]).
 
new_tables(1,nopk,[ 'ClienteConversion','Cliente',[ 6,7,1 ],'GXA0001','ClienteGXI',[ 6 ],[ [ 4,del ],[ 3,del ],[ 2,del ],[ 1,upd ] ],1 ]).
new_tables(5,pk,[ 'Cliente1Conversion','Cliente1',[ 1,2,3,4 ],'GXA0005',[],[],[ [ 7,del ],[ 6,del ] ],1 ]).
 
conv_tables_i(5,[ [ 1 ] ]).
conv_tables_i(1,[ [ 1 ] ]).
 
table_exists_i(1,1,'Cliente').
 
nav_view_i(2000,[ 6,7,1 ],[ 6,7,1 ],[],[ [ 2000,[] ] ],[ [ [ 1,6 ],[ 1,7 ],[ 1,1 ] ],n,[ [ 1,many ] ],[],[],[ none ],[],[],[] ]).
 
att_map_i(1,6,6).
att_map_i(1,7,7).
att_map_i(1,1,1).
 
lv_i(2,2000,1).
 
 
 
reorg_upd_i(1,[ 2000 ]).
 
 
 
 
 
 
att_prop_i(2,6,'ExternalName','FacturaNumero',d).
att_prop_i(2,6,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(2,6,'EmptyAsNull','Yes',d).
att_prop_i(2,6,idBasedOn,'',d).
att_prop_i(2,6,'AUTONUMBER','0',d).
att_prop_i(2,6,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,6,'AttRegEx','',d).
att_prop_i(2,6,'AttValidationFailedMsg','',d).
att_prop_i(2,6,'FullName','FacturaNumero',v).
att_prop_i(1,6,'ExternalName','FacturaNumero',d).
att_prop_i(1,6,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(1,6,'EmptyAsNull','Yes',d).
att_prop_i(1,6,idBasedOn,'',d).
att_prop_i(1,6,'AUTONUMBER','0',d).
att_prop_i(1,6,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,6,'AttRegEx','',d).
att_prop_i(1,6,'AttValidationFailedMsg','',d).
att_prop_i(1,6,'FullName','FacturaNumero',v).
att_prop_i(1,7,'ExternalName','FacturaFecha',d).
att_prop_i(1,7,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(1,7,'EmptyAsNull','Yes',d).
att_prop_i(1,7,idBasedOn,'',d).
att_prop_i(1,7,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,7,'AttRegEx','',d).
att_prop_i(1,7,'AttValidationFailedMsg','',d).
att_prop_i(1,7,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(1,7,'FullName','FacturaFecha',v).
att_prop_i(2,7,'ExternalName','FacturaFecha',d).
att_prop_i(2,7,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(2,7,'EmptyAsNull','Yes',d).
att_prop_i(2,7,idBasedOn,'',d).
att_prop_i(2,7,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,7,'AttRegEx','',d).
att_prop_i(2,7,'AttValidationFailedMsg','',d).
att_prop_i(2,7,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(2,7,'FullName','FacturaFecha',v).
att_prop_i(1,1,'ExternalName','ClienteId',d).
att_prop_i(1,1,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(1,1,'EmptyAsNull','Yes',d).
att_prop_i(1,1,idBasedOn,64,v).
att_prop_i(1,1,'AUTONUMBER','-1',v).
att_prop_i(1,1,'AUTONUMBER_START','1',d).
att_prop_i(1,1,'AUTONUMBER_STEP','1',d).
att_prop_i(1,1,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(1,1,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,1,'AttRegEx','',d).
att_prop_i(1,1,'AttValidationFailedMsg','',d).
att_prop_i(1,1,'FullName','ClienteId',v).
att_prop_i(2,1,'ExternalName','ClienteId',d).
att_prop_i(2,1,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(2,1,'EmptyAsNull','Yes',d).
att_prop_i(2,1,idBasedOn,64,v).
att_prop_i(2,1,'AUTONUMBER','-1',v).
att_prop_i(2,1,'AUTONUMBER_START','1',d).
att_prop_i(2,1,'AUTONUMBER_STEP','1',d).
att_prop_i(2,1,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(2,1,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,1,'AttRegEx','',d).
att_prop_i(2,1,'AttValidationFailedMsg','',d).
att_prop_i(2,1,'FullName','ClienteId',v).
att_prop_i(2,2,'ExternalName','ClienteNombre',d).
att_prop_i(2,2,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(2,2,'EmptyAsNull','Yes',d).
att_prop_i(2,2,idBasedOn,65,v).
att_prop_i(2,2,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,2,'DB_NLS_SUPPORT','No',d).
att_prop_i(2,2,'AttRegEx','',d).
att_prop_i(2,2,'AttValidationFailedMsg','',d).
att_prop_i(2,2,'FullName','ClienteNombre',v).
att_prop_i(1,2,'ExternalName','ClienteNombre',d).
att_prop_i(1,2,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(1,2,'EmptyAsNull','Yes',d).
att_prop_i(1,2,idBasedOn,65,v).
att_prop_i(1,2,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,2,'DB_NLS_SUPPORT','No',d).
att_prop_i(1,2,'AttRegEx','',d).
att_prop_i(1,2,'AttValidationFailedMsg','',d).
att_prop_i(1,2,'FullName','ClienteNombre',v).
att_prop_i(2,3,'ExternalName','ClienteApellido',d).
att_prop_i(2,3,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(2,3,'EmptyAsNull','Yes',d).
att_prop_i(2,3,idBasedOn,65,v).
att_prop_i(2,3,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,3,'DB_NLS_SUPPORT','No',d).
att_prop_i(2,3,'AttRegEx','',d).
att_prop_i(2,3,'AttValidationFailedMsg','',d).
att_prop_i(2,3,'FullName','ClienteApellido',v).
att_prop_i(1,3,'ExternalName','ClienteApellido',d).
att_prop_i(1,3,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(1,3,'EmptyAsNull','Yes',d).
att_prop_i(1,3,idBasedOn,65,v).
att_prop_i(1,3,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,3,'DB_NLS_SUPPORT','No',d).
att_prop_i(1,3,'AttRegEx','',d).
att_prop_i(1,3,'AttValidationFailedMsg','',d).
att_prop_i(1,3,'FullName','ClienteApellido',v).
att_prop_i(2,4,'ExternalName','ClienteFechaNacimiento',d).
att_prop_i(2,4,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(2,4,'EmptyAsNull','Yes',d).
att_prop_i(2,4,idBasedOn,'',d).
att_prop_i(2,4,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,4,'AttRegEx','',d).
att_prop_i(2,4,'AttValidationFailedMsg','',d).
att_prop_i(2,4,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(2,4,'FullName','ClienteFechaNacimiento',v).
att_prop_i(1,4,'ExternalName','ClienteFechaNacimiento',d).
att_prop_i(1,4,'ExternalNamespace','Ejercicio0803',d).
att_prop_i(1,4,'EmptyAsNull','Yes',d).
att_prop_i(1,4,idBasedOn,'',d).
att_prop_i(1,4,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,4,'AttRegEx','',d).
att_prop_i(1,4,'AttValidationFailedMsg','',d).
att_prop_i(1,4,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(1,4,'FullName','ClienteFechaNacimiento',v).
 
tbl_prop_i(1,1,'AllDirSuper',[ [ 5,[ 1 ] ] ],v).
tbl_prop_i(1,1,'DirSuper',[ [ 5,[ 1 ] ] ],v).
tbl_prop_i(1,1,'DirSubor',[ [ 3,[ 6 ] ] ],v).
tbl_prop_i(2,1,'DirSubor',[ [ 3,[ 6 ] ] ],v).
tbl_prop_i(1,3,'AllDirSuper',[ [ 1,[ 6 ] ] ],v).
tbl_prop_i(1,3,'DirSuper',[ [ 1,[ 6 ] ] ],v).
tbl_prop_i(2,3,'AllDirSuper',[ [ 1,[ 6 ] ] ],v).
tbl_prop_i(2,3,'DirSuper',[ [ 1,[ 6 ] ] ],v).
tbl_prop_i(1,5,'DirSubor',[ [ 1,[ 1 ] ] ],v).
 
tbl_att_prop_i(2,1,6,'AllowNulls',n).
tbl_att_prop_i(1,1,6,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0001','T.FacturaNumero','AllowNulls',n).
tbl_att_prop_i(2,1,7,'AllowNulls',n).
tbl_att_prop_i(1,1,7,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0001','T.FacturaFecha','AllowNulls',n).
tbl_att_prop_i(2,1,1,'AllowNulls',n).
tbl_att_prop_i(2,1,1,'AUTONUMBER',y).
tbl_att_prop_i(1,1,1,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0001','T.ClienteId','AllowNulls',n).
tbl_att_prop_i(2,1,2,'AllowNulls',n).
tbl_att_prop_i(2,1,3,'AllowNulls',n).
tbl_att_prop_i(2,1,4,'AllowNulls',n).
tbl_att_prop_i(1,5,1,'AllowNulls',n).
tbl_att_prop_i(1,5,1,'AUTONUMBER',y).
tbl_att_prop_i(1,5,2,'AllowNulls',n).
tbl_att_prop_i(1,5,3,'AllowNulls',n).
tbl_att_prop_i(1,5,4,'AllowNulls',n).
 
 
 
 
 
 
 
 
 
insert_w_subselect_i(1).
 
 
 
 
 
 
 
is_dynamic_trn_i(1,5,no).
is_dynamic_trn_i(1,1,no).
is_dynamic_trn_i(2,1,no).
is_dynamic_trn_i(1,3,no).
 
 
 
 
 
 
