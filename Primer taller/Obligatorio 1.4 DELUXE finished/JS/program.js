var precio=50;
var minutos=7.2;
var hora=388;
var bajada=50;
var valijas=18; //primera sin cargo
						//zonas turisticas		//hay 19 paradas		28 zonas turisticas
//1-Azotea de haedo
//2-beverly hills
//3-Cachimba del rey
//4-Casa de la cultura
//5-Casapueblo
//6-Catedral san fernando
//7-Centro de convenciones
//8-conrad
//9-cuartel de dragones
//10-faro punta del este
//11-pablo atchugarry
//12-iglecia candelaria x
//13-jose ignacio				
//14-los dedos
//15-museo del mar
//16-museo mazzoni
//17-museo ralli
//18-la barra shopping oh
//19-jaguel
//20-playa bikini
//21-plaza artigas				
//22-torre del vigia 
//23-plazoleta gran bretaña			
//24-puente de la barra			
//25-puente garzon				
//26-puerto punta del este		
//27-punta shopping
//28-san rafael

//hay que arreglar		PZK  PZT    ZZK ZZT
var turisticas=["Azotea de Haedo","Beverly Hills","Cachimba del Rey","Casa de la Cultura","CasaPueblo","Catedral San Fernando","Centro de Convenciones","Conrad","Cuartel de Dragones","Faro Punta del Este","Fundacion Pablo Atchugarry","Iglesia de la Candelaria","José Ignacio","Los Dedos","Museo del Mar","Museo Mazzoni","Museo Ralli","Oh! La Barra","Parque Jaguel","Playa Bikini","Plaza Artigas","Plaza Torre del Vigía","Plazoleta Gran Bretaña","Puente de la Barra","Puente Garzón","Puerto Punta del Este","Punta Shopping","San Rafael"];
var paradas=["Aeropuerto Punta del Este","Barrio Norte","Biarriz","Cantegril","Casino Nogaro","Colonial","La Fragata","Hospital Maldonado","Lafayette","La Barra","Lausana","Maldonado Nuevo","Marco de los Reyes","Oasis","Punta Shopping","Sanatorio Mautone","San Rafael","Terminal de Maldonado","Terminal Punta del Este"];
var interes=["Asociacion Española","Banco de Seguros","Blue Cross and Blue Shield","Casmu","Campus Municipal","Ceter","Consulado Argentiono","Correo","Credencial","DNIC","Hospital","Intendecia Municipal de Moasis Heladería El Faro aldonado","Jefatura","Migraciones","Sanatorio Cantegril","Sanatorio Mautones"]; 
					/*paradas a	zonas kilometros*/	
//		  1		2	  3     4     5     6	  7		8	  9		10	  11	12	  13//	14	  15	16	  17	18	  19	20	  21	22	  23	24-   25-	26//  27    28			
var PZK=[[24.1 ,25.9 ,23.4 ,21.9 ,14   ,22.1 ,27.5 ,24.5 ,21.8 ,26.8 ,54.4 ,26.8 ,64.4 ,26.2 ,31.8 ,20.5 ,25.7 ,32.4 ,27.1 ,34.8 ,25.9 ,21.3 ,27.1 ,30.2 ,61.9 ,26.4 ,24.6 ,26.5 ],//aeropueto parada
		 [4    ,7.1  ,3.4  ,1.7  ,11.5 ,1.3  ,7    ,7.6  ,1.5  ,10.1 ,20.8 ,10   ,34   ,9.1  ,11.6 ,1.2  ,6.3  ,12.3 ,6.9  ,14.6 ,9    ,2.2  ,10.3 ,10   ,41.7 ,9.6  ,6.3  ,7.1  ],//taxi barrio norte
		 [4    ,6.1  ,3.5  ,3.5  ,12.9 ,3.5  ,6    ,7.7  ,3.6  ,10.1 ,19.8 ,10.1 ,33   ,9.2  ,10.6 ,3.3  ,6.5  ,11.3 ,5.9  ,13.6 ,9    ,4.4  ,10.4 ,9.5  ,40.7 ,9.7  ,6.3  ,7.5  ],//taxi birritz
		 [1.8  ,3.1  ,2.3  ,2.8  ,12   ,3.4  ,4.7  ,3.2  ,3.1  ,5.6  ,19.9 ,5.6  ,33   ,4.7  ,10.7 ,3.3  ,2.8  ,11.3 ,3.7  ,13.6 ,4.5  ,3    ,5.8  ,9.5  ,40.8 ,5.2  ,1.8  ,3.6  ],//taxi cantegril
		 [5.2  ,4.3  ,5.9  ,6.2  ,14.2 ,7    ,5.6  ,1.2  ,6.7  ,1.9  ,20.5 ,1.8  ,33.6 ,0.55 ,11.3 ,6.9  ,4.5  ,11.9 ,5.4  ,14.3 ,0.7  ,6.6  ,2.1  ,10.1 ,41.4 ,1.4  ,2.8  ,4.6  ],//taxi nogaro
		 [2.9  ,6.6  ,2.3  ,0.35 ,10.3 ,0.047,6.6  ,6    ,0.16 ,8.3  ,20.4 ,8.5  ,33.5 ,7.6  ,11.2 ,0.15 ,5.2  ,11.8 ,6.5  ,14.1 ,7.5  ,0.55 ,8.8  ,10   ,41.3 ,8    ,4.7  ,5.9  ],//taxi colonial
		 [5.6  ,5.3  ,6.3  ,7.4  ,14.7 ,7.6  ,6.6  ,1.7  ,7.2  ,1.4  ,20.5 ,1.4  ,33.7 ,1    ,11.3 ,7.4  ,5.6  ,12   ,6.6  ,14.3 ,0.3  ,7.2  ,1.7  ,10.2 ,41.4 ,1    ,3.3  ,4.6  ],//parada de taxi la fragata
		 [3.7  ,7.1  ,3    ,1.7  ,9.7  ,1.1  ,7    ,6.9  ,1.2  ,9.2  ,20.8 ,9.2  ,33.9 ,8.1  ,11.6 ,0.95 ,5.9  ,12.2 ,6.9  ,14.6 ,8.3  ,1.1  ,9.5  ,10.4 ,41.7 ,8.8  ,5.2  ,6.6  ],//hospital maldonado BUS(0610) 
		 [6    ,6.2  ,6.7  ,7.7  ,15.2 ,7.9  ,7.5  ,2.1  ,7.6  ,0.6  ,21.4 ,0.6  ,34.6 ,1.9  ,12.2 ,7.8  ,5.4  ,12.9 ,7.5  ,15.2 ,0.7  ,7.5  ,0.9  ,11.1 ,42.3 ,0.4  ,3.7  ,5.5  ],//lafayette BUS 0078
		 [9.6  ,8.4  ,9.1  ,10.4 ,20.4 ,10.7 ,6.9  ,10.8 ,10.8 ,12.8 ,8.9  ,12.8 ,22   ,11.9 ,2.5  ,11.2 ,8.8  ,0.29 ,8.2  ,2.6  ,11.8 ,10.7 ,13   ,1.7  ,29.8 ,12.6 ,10.3 ,8.9  ],//la barra taxi
		 [6.2  ,10.1 ,5.5  ,4.5  ,6.8  ,4.3  ,10   ,8.5  ,4.4  ,10.8 ,23.8 ,10.9 ,37   ,10.2 ,14.3 ,4.2  ,8.5  ,14.9 ,8.5  ,17.3 ,10   ,3.9  ,11.1 ,13.5 ,44.8 ,10.4 ,7.8  ,9.2  ],//taxi lausana
		 [3.1  ,5.7  ,2.6  ,2.5  ,12.9 ,2.6  ,5.6  ,6.8  ,2.7  ,9.2  ,19.4 ,9.2  ,32.5 ,8.3  ,10.2 ,2.4  ,6.1  ,10.8 ,5.5  ,13.2 ,8.1  ,3.4  ,9.4  ,9    ,40.3 ,8.8  ,5.4  ,7.1  ],//parada de taxi maldonado nuevo
		 [2.6  ,5.2  ,2    ,0.24 ,10.5 ,0.15 ,5.8  ,6.1  ,0.25 ,8.4  ,19.6 ,8.6  ,32.8 ,7.7  ,10.4 ,0.2  ,4.9  ,11   ,5.7  ,13.4 ,7.6  ,0.65 ,8.7  ,9.2  ,40.5 ,8.1  ,4.8  ,5.6  ],//Centro maldonado Marco De Los Reyes
		 [5.3  ,4.5  ,6    ,7    ,14.3 ,7.2  ,5.8  ,1.8  ,6.9  ,1.4  ,20.6 ,1.5  ,33.8 ,0.8  ,11.4 ,7.1  ,4.6  ,12.1 ,5.6  ,14.4 ,0.4  ,6.8  ,1.8  ,10.3 ,41.6 ,1.1  ,3    ,4.8  ],//oasis Heladería El Faro
		 [3.4  ,2.1  ,4.1  ,5.2  ,14.1 ,5.5  ,3.4  ,1.9  ,5.2  ,4.2  ,19.1 ,4.1  ,32.3 ,3.2  ,9.9  ,5.4  ,2.4  ,10.6 ,3.4  ,12.9 ,3.2  ,5.1  ,4.4  ,8.7  ,40   ,3.9  ,0    ,1.7  ],//taxi punta shopping
		 [2.3  ,4.8  ,1.6  ,0.85 ,9.7  ,0.85 ,5.8  ,5.2  ,0.7  ,7.5  ,19.6 ,7.7  ,32.7 ,6.7  ,10.4 ,1.4  ,4.9  ,11   ,4.5  ,13.4 ,6.6  ,0.45 ,7.8  ,9.2  ,40.5 ,7.1  ,3.9  ,5.3  ],//Taxi Mautone
		 [4.6  ,2.1  ,5.3  ,6.3  ,16   ,6.7  ,3.3  ,2.9  ,7    ,5    ,17   ,4.9  ,30.2 ,4    ,7.9  ,7.1  ,2.3  ,8.5  ,3.3  ,10.8 ,3.9  ,6.9  ,5.2  ,6.3  ,38   ,4.8  ,2.5  ,1.4  ],//san rafael BUS(0231)
		 [2    ,4.5  ,1.3  ,1    ,10.5 ,1.1  ,5.5  ,5.3  ,1.2  ,7.5  ,19.3 ,7.4  ,32.4 ,6.5  ,10.1 ,1.4  ,4.2  ,10.7 ,4.2  ,13   ,6.8  ,1.2  ,8    ,8.9  ,40.2 ,7.3  ,3.7  ,5    ],//Taxi Terminal Maldonado
		 [4.8  ,4.5  ,5.5  ,6.7  ,14.1 ,6.9  ,5.8  ,0.95 ,6.6  ,2    ,19.8 ,2    ,32.9 ,0.4  ,10.6 ,6.8  ,4.2  ,11.2 ,5.8  ,13.5 ,0.9  ,6.5  ,2.3  ,9.4  ,40.7 ,1.8  ,2.5  ,3.9  ] //COT Terminal Punta del Este
		 ];		
		 					/*paradas a	zonas tiempo minutos*/		
var PZT=[[25   ,28   ,24   ,23   ,13   ,23   ,29   ,23   ,22   ,30   ,44   ,30   ,58   ,29   ,36   ,24   ,28   ,38   ,30   ,41   ,27   ,21   ,31   ,30   ,69   ,30   ,24   ,29   ],//aeropuerto parada
		 [8    ,12   ,7    ,6    ,14   ,5    ,13   ,14   ,5    ,20   ,30   ,19   ,43   ,17   ,18   ,4    ,12   ,20   ,12   ,23   ,17   ,7    ,20   ,15   ,50   ,20   ,11   ,13   ],//taxi barrio norte
		 [9    ,11   ,8    ,10   ,18   ,11   ,12   ,14   ,12   ,21   ,30   ,20   ,41   ,18   ,18   ,10   ,13   ,20   ,12   ,23   ,18   ,13   ,21   ,14   ,49   ,20   ,12   ,15   ],//taxi biarritz
		 [4    ,8    ,5    ,7    ,16   ,9    ,10   ,6    ,7    ,12   ,29   ,12   ,42   ,10   ,17   ,8    ,7    ,19   ,9    ,22   ,10   ,7    ,13   ,14   ,49   ,12   ,4    ,8    ],//taxi cantegril
		 [12   ,12   ,13   ,15   ,21   ,16   ,14   ,4    ,15   ,6    ,31   ,5    ,41   ,7    ,18   ,14   ,11   ,20   ,13   ,24   ,3    ,13   ,6    ,14   ,48   ,5    ,7    ,11   ],//taxi  nogaro
		 [9    ,13   ,7    ,4    ,15   ,1    ,13   ,12   ,2    ,18   ,31   ,19   ,44   ,16   ,18   ,2    ,13   ,20   ,13   ,23   ,15   ,6    ,19   ,17   ,52   ,17   ,11   ,14   ],//taxi colonial
		 [12   ,11   ,13   ,16   ,24   ,19   ,13   ,6    ,17   ,5    ,29   ,4    ,41   ,11   ,17   ,18   ,11   ,19   ,13   ,22   ,2    ,17   ,5    ,13   ,48   ,4    ,9    ,10   ],//parada de taxi la fragata
		 [10   ,14   ,8    ,6    ,14   ,4    ,15   ,12   ,5    ,20   ,31   ,20   ,45   ,17   ,20   ,3    ,13   ,21   ,14   ,25   ,15   ,4    ,20   ,18   ,53   ,18   ,11   ,14   ],//taxi hospital maldonado 
		 [14   ,12   ,15   ,16   ,24   ,17   ,15   ,7    ,17   ,7    ,30   ,7    ,43   ,4    ,17   ,18   ,14   ,19   ,15   ,22   ,2    ,17   ,3    ,15   ,50   ,5    ,10   ,12   ],//taxi lafayette
		 [14   ,12   ,13   ,16   ,30   ,18   ,12   ,18   ,18   ,22   ,11   ,21   ,24   ,19   ,6    ,19   ,13   ,4    ,13   ,4    ,18   ,18   ,21   ,4    ,31   ,21   ,17   ,15   ],//la barra taxi
		 [14   ,17   ,12   ,10   ,9    ,9    ,19   ,14   ,9    ,20   ,36   ,20   ,49   ,18   ,22   ,9    ,16   ,24   ,17   ,28   ,17   ,7    ,21   ,22   ,57   ,19   ,14   ,17   ],//taxi lausana//
		 [6    ,9    ,6    ,8    ,18   ,9    ,11   ,12   ,9    ,18   ,29   ,17   ,41   ,15   ,17   ,8    ,11   ,18   ,11   ,21   ,16   ,11   ,18   ,13   ,48   ,17   ,10   ,12   ],//taxi maldonado nuevo//
		 [8    ,12   ,7    ,3    ,15   ,2    ,13   ,12   ,3    ,20   ,31   ,19   ,43   ,16   ,19   ,2    ,13   ,20   ,13   ,23   ,15   ,8    ,18   ,16   ,50   ,17   ,11   ,13   ],//taxi marco de los reyes//
		 [11   ,10   ,12   ,13   ,19   ,14   ,13   ,5    ,14   ,5    ,29   ,5    ,41   ,10   ,16   ,15   ,10   ,18   ,12   ,21   ,2    ,13   ,5    ,14   ,48   ,4    ,8    ,11   ],//oasis Heladería El Faro//
 		 [7    ,4    ,8    ,11   ,18   ,13   ,7    ,5    ,12   ,10   ,26   ,10   ,38   ,7    ,13   ,12   ,5    ,15   ,7    ,18   ,9    ,11   ,10   ,11   ,46   ,10   ,0    ,4    ],//taxi punta shopping//
		 [6    ,10   ,5    ,11   ,12   ,11   ,12   ,8    ,10   ,15   ,30   ,15   ,42   ,12   ,17   ,5    ,10   ,19   ,11   ,22   ,12   ,6    ,15   ,14   ,49   ,13   ,8    ,11   ],//Taxi Mautone //
		 [10   ,5    ,11   ,14   ,22   ,16   ,8    ,7    ,15   ,11   ,25   ,10   ,38   ,8    ,13   ,15   ,6    ,14   ,8    ,17   ,9    ,14   ,11   ,9    ,45   ,10   ,7    ,3    ],//san rafael	BUS - (0231)
		 [5    ,10   ,4    ,4    ,15   ,5    ,11   ,9    ,5    ,16   ,29   ,16   ,42   ,13   ,17   ,6    ,10   ,18   ,11   ,22   ,13   ,4    ,16   ,14   ,48   ,15   ,9    ,11   ],//Taxi Terminal Maldonado//
		 [10   ,8    ,11   ,13   ,18   ,14   ,11   ,12   ,14   ,6    ,27   ,5    ,39   ,5    ,14   ,14   ,9    ,15   ,11   ,19   ,4    ,12   ,6    ,11   ,46   ,5    ,6    ,8    ] //COT - Terminal Punta del Este
		 ];	
					/*zonas a zonas kilometros*/
		//1		2	  3     4     5     6	  7		8	  9     10    11	12	  13	14	  15	16	  17	18    19	20	  21    22    23/	24	  25	26	  27    28
var ZZK=[[0    ,3.2  ,0.75 ,2    ,12.9 ,2.4  ,3.2  ,4.2  ,2.6  ,6.6  ,18.5 ,6.6  ,31.7 ,5.7  ,9.3  ,3    ,2.9  ,10   ,2.5  ,12.3 ,5.5  ,2.9  ,6.8  ,7.8  ,39.5 ,6.2  ,2.8  ,3.6  ],//1-Azotea de Haedo
		 [3.3  ,0    ,4.4  ,5.7  ,14.7 ,5.9  ,1.6  ,3.4  ,6    ,6.4  ,17.1 ,6.3  ,30.3 ,5.4  ,8    ,6.5  ,0.35 ,8.6  ,1.6  ,10.9 ,4.7  ,5.4  ,6.6  ,6.4  ,38.1 ,5.4  ,2.5  ,1.7  ],//2-Beverly Hills
		 [0.75 ,4.2  ,0    ,1.2  ,11.1 ,1.7  ,4.2  ,4.8  ,1.7  ,7.2  ,18   ,7.2  ,31.1 ,6.3  ,8.8  ,1.9  ,3.5  ,9.4  ,4.1  ,11.7 ,6.1  ,1.5  ,7.5  ,3.4  ,7.2  ,38.9 ,6.8  ,4.2  ],//3-Cachimba del Rey
		 [2.5  ,5    ,1.8  ,0    ,10.3 ,0.3  ,5.7  ,6    ,0.19 ,8.3  ,19.5 ,8.4  ,32.6 ,7.5  ,10.3 ,0.45 ,4.7  ,10.9 ,5.6  ,13.2 ,7.4  ,0.5  ,8.7  ,4.7  ,8.7  ,40.4 ,7.9  ,5.5  ],//4-Casa de la Cultura
		 [13.1 ,14.8 ,12.4 ,10.7 ,0    ,10.9 ,16.3 ,13.3 ,10.6 ,15.6 ,48.3 ,15.6 ,65.8 ,15   ,21   ,10.8 ,14.5 ,21.6 ,15.4 ,24   ,15.1 ,10.1 ,15.9 ,13.5 ,19.4 ,73.2 ,15.2 ,15.3 ],//5-CasaPueblo
		 [2.5  ,5    ,1.8  ,0.3  ,10.3 ,0    ,5.7  ,6    ,0.12 ,8.3  ,19.5 ,8.4  ,32.6 ,7.5  ,10.3 ,0.18 ,4.7  ,10.9 ,5.6  ,13.2 ,7.4  ,0.5  ,8.7  ,4.7  ,8.7  ,40.4 ,7.9  ,5.5  ],//6-Catedral San Fernando
		 [3.2  ,1.6  ,4.3  ,5.5  ,18.5 ,5.8  ,0    ,4.7  ,5.9  ,7    ,15.8 ,7    ,29   ,6.1  ,6.6  ,6.4  ,2.1  ,7.2  ,1.4  ,9.6  ,6.1  ,5.8  ,7.2  ,4.1  ,5    ,36.7 ,6.7  ,3    ],//7-Centro de Convenciones
		 [4.1  ,3.2  ,4.8  ,5.1  ,13.1 ,5.9  ,4.5  ,0    ,5.6  ,3.3  ,19.8 ,3.3  ,32.9 ,2.4  ,10.6 ,5.8  ,3.4  ,11.2 ,4.3  ,13.6 ,2.2  ,5.5  ,3.6  ,1.7  ,9    ,40.7 ,2.5  ,2.8  ],//8-Conrad
		 [2.4  ,4.9  ,1.7  ,0.19 ,10.2 ,0.12 ,5.6  ,5.9  ,0    ,8.2  ,19.3 ,8.3  ,32.5 ,7.4  ,10.1 ,0.3  ,4.6  ,10.8 ,5.4  ,13.1 ,7.3  ,0.4  ,8.6  ,4.6  ,8.6  ,40.3 ,7.8  ,5.4  ],//9-Cuartel de Dragones
		 [6.7  ,6.4  ,7.4  ,7.7  ,15.7 ,8.5  ,7.6  ,2.7  ,8.2  ,0    ,21.6 ,0.16 ,34.7 ,2    ,12.4 ,8.4  ,6.6  ,13   ,7.6  ,15.4 ,1.3  ,8.1  ,0.45 ,4.4  ,10.8 ,42.5 ,0.5  ,5.7  ],//10-Faro Punta del Este
		 [18.8 ,17.6 ,18.3 ,19.5 ,32.5 ,19.8 ,16.1 ,19.9 ,19.9 ,22   ,0    ,21.9 ,22.3 ,21   ,9.2  ,20.4 ,18   ,8.6  ,17.4 ,6.4  ,20.9 ,19.8 ,22.2 ,19.5 ,11.3 ,30.1 ,21.8 ,18.1 ],//11-Pablo Atchugarry
		 [6.7  ,6.4  ,7.4  ,8    ,16   ,8.8  ,7.6  ,3    ,8.5  ,0.16 ,21.6 ,0    ,34.7 ,2    ,12.4 ,8.7  ,6.6  ,13   ,7.6  ,15.4 ,1.3  ,8.4  ,0.4  ,4.4  ,10.8 ,42.5 ,0.7  ,5.7  ],//12-Iglecia Candelaria
		 [31.6 ,30.3 ,31.1 ,32.3 ,45.3 ,32.6 ,28.9 ,32.7 ,32.7 ,34.7 ,22.3 ,34.7 ,0    ,33.8 ,26.9 ,33.2 ,30.8 ,21.7 ,30.1 ,19.5 ,33.7 ,32.6 ,35   ,23.6 ,7.8  ,34.5 ,32.3 ,30.8 ],//13-Jose Ignacio
		 [4.7  ,4.3  ,5.4  ,6.4  ,14.2 ,7.1  ,5.6  ,1.2  ,6.7  ,2.5  ,19.6 ,2.5  ,32.7 ,0    ,10.4 ,6.9  ,4.6  ,11   ,5.6  ,13.3 ,1.5  ,6.7  ,2.7  ,2.4  ,8.8  ,40.5 ,2.3  ,3.7  ],//14-Los Dedos
		 [9.2  ,8    ,8.7  ,10   ,23   ,10.2 ,6.5  ,10.4 ,10.4 ,12.4 ,9.2  ,12.4 ,26.9 ,11.4 ,0    ,10.8 ,8.4  ,2.9  ,7.8  ,5.1  ,11.4 ,10.3 ,12.6 ,9.9  ,1.8  ,34.7 ,12.2 ,8.5  ],//15-Museo del Mar
		 [2.7  ,5.8  ,2.2  ,0.45 ,11   ,0.18 ,5.8  ,6.4  ,0.3  ,8.8  ,19.5 ,8.8  ,32.7 ,7.9  ,10.3 ,0    ,5.1  ,11   ,5.6  ,13.3 ,7.7  ,0.7  ,9    ,5    ,8.8  ,40.5 ,8.4  ,5.8  ],//16-Museo Mazzoni
		 [2.9  ,0.35 ,3.6  ,4.6  ,14.4 ,5    ,2    ,3.6  ,5.5  ,6    ,17.6 ,6    ,30.7 ,5.1  ,8.4  ,5.7  ,0    ,9    ,1.1  ,11.4 ,4.9  ,5.2  ,6.3  ,2.2  ,6.8  ,38.5 ,5.6  ,2    ],//17-Museo Ralli
		 [9.9  ,8.7  ,9.4  ,10.7 ,23.7 ,10.9 ,7.2  ,11.1 ,11.1 ,13.1 ,8.6  ,13.1 ,21.7 ,12.1 ,2.8  ,11.5 ,9.1  ,0    ,8.5  ,2.3  ,12.1 ,11   ,13.3 ,10.6 ,2.5  ,29.5 ,12.9 ,9.2  ],//18-La Barra Shopping Oh
		 [2.4  ,1.5  ,3.1  ,4.4  ,15.4 ,4.6  ,1.4  ,4.6  ,4.8  ,7.1  ,17   ,7    ,30.2 ,6.1  ,7.8  ,5.2  ,1.1  ,8.4  ,0    ,10.8 ,5.9  ,4.7  ,7.3  ,3.3  ,6.2  ,37.9 ,6.6  ,2.9  ],//19-Jaguel
		 [12.2 ,11   ,11.7 ,13   ,26   ,13.2 ,9.5  ,13.3 ,13.3 ,15.4 ,6.4  ,15.3 ,19.5 ,14.4 ,5.1  ,13.8 ,11.4 ,2.4  ,10.8 ,0    ,14.3 ,13.3 ,15.6 ,12.9 ,4.7  ,27.3 ,15.2 ,11.5 ],//20-Playa Bikini
		 [5.8  ,5.5  ,6.5  ,7.1  ,14.7 ,8    ,6.7  ,2.1  ,7.6  ,1.1  ,20.7 ,1.1  ,33.8 ,1.1  ,11.5 ,7.8  ,5.7  ,12.1 ,6.7  ,14.5 ,0    ,7    ,1.4  ,9.9  ,41.6 ,0.85 ,3.5  ,4.8  ],//21-Plaza Artigas                                                                                                   
		 [2.5  ,5.7  ,1.8  ,0.5  ,10.1 ,0.5  ,5.7  ,5.6  ,0.4  ,7.9  ,19.4 ,8    ,32.6 ,7.3  ,10.3 ,0.7  ,4.7  ,10.9 ,5.6  ,13.2 ,7.6  ,0    ,8.2  ,4.3  ,8.7  ,40.4 ,7.5  ,5.5  ],//22-Torre del Vigia
		 [7    ,6.6  ,7.7  ,8.2  ,16.2 ,9.1  ,7.9  ,3.2  ,8.8  ,0.45 ,21.8 ,0.4  ,35   ,2.3  ,12.6 ,9    ,6.9  ,13.3 ,7.9  ,15.6 ,1.6  ,8.7  ,0    ,4.6  ,11.1 ,42.8 ,1    ,6    ],//23-Plazoleta Gran Bretaña	taba despues de este shopping
		 [3.4  ,2.1  ,4.1  ,5.2  ,14.1 ,5.5  ,3.4  ,1.9  ,5.2  ,4.2  ,19.1 ,4.1  ,24.4 ,3.2  ,9.9  ,5.4  ,2.4  ,10.6 ,3.4  ,12.9 ,9.8  ,5.1  ,4.4  ,0    ,8.3  ,40   ,3.9  ,1.7  ],//24-Puente de la Barra
		 [7.9  ,6.7  ,7.4  ,8.7  ,21.7 ,8.9  ,5.2  ,9.1  ,9.1  ,11.1 ,11.2 ,11.1 ,7.8  ,10.1 ,2    ,9.5  ,7.1  ,2.7  ,6.5  ,5    ,41.5 ,9    ,11.3 ,8.6  ,0    ,32.2 ,10.9 ,7.2  ],//25-Puente Garzon
		 [39.3 ,38.1 ,38.8 ,40.1 ,63.1 ,40.3 ,36.6 ,40.5 ,40.5 ,42.5 ,30.1 ,42.5 ,34.9 ,41.5 ,34.7 ,40.9 ,38.5 ,29.5 ,37.9 ,27.3 ,0.85 ,40.4 ,42.7 ,40   ,31.9 ,0    ,42.3 ,38.6 ],//26-Puerto Punta del Este
		 [6.5  ,6.5  ,7.2  ,7.5  ,15.5 ,8.4  ,7.8  ,2.5  ,8.1  ,0.5  ,21.7 ,0.7  ,32.3 ,2.2  ,12.5 ,8.3  ,5.9  ,13.2 ,7.8  ,15.5 ,3.2  ,8    ,1    ,4.2  ,11   ,42.7 ,0    ,5.9  ],//27-Punta Shopping		cambie de lugar cuidado
		 [3.6  ,1.7  ,4.3  ,5.3  ,15.2 ,5.7  ,3    ,3    ,5.7  ,5.2  ,17.4 ,5.2  ,30.6 ,4.3  ,8.2  ,6.4  ,2    ,8.9  ,3    ,11.2 ,4.7  ,5.9  ,5.4  ,1.6  ,6.7  ,38.4 ,5    ,0    ],//28-San Rafael		mal??
		 ];
					/*zonas a zonas tiempo minutos*/
var ZZT=[[0    ,7    ,2    ,6    ,18   ,9    ,8    ,8    ,9    ,14   ,25   ,14   ,39   ,11   ,14   ,9    ,7    ,15   ,7    ,19   ,12   ,8    ,14   ,11   ,46   ,12   ,6    ,8    ],//1-Azotea de Haedo
		 [7    ,0    ,7    ,11   ,21   ,13   ,4    ,8    ,13   ,13   ,23   ,13   ,37   ,10   ,12   ,13   ,1    ,13   ,4    ,16   ,12   ,13   ,13   ,9    ,44   ,13   ,6    ,4    ],//2-Beverly Hills
		 [9    ,6    ,0    ,4    ,17   ,6    ,7    ,8    ,7    ,14   ,24   ,14   ,38   ,11   ,13   ,7    ,7    ,14   ,7    ,17   ,12   ,6    ,14   ,6    ,9    ,44   ,15   ,8,   ],//3-Cachimba del Rey
		 [7    ,11   ,5    ,0    ,14   ,4    ,12   ,12   ,2    ,19   ,28   ,18   ,43   ,16   ,17   ,5    ,11   ,19   ,12   ,22   ,15   ,6    ,19   ,10   ,14   ,49   ,17   ,12   ],//4-Casa de la Cultura
		 [18   ,19   ,17   ,15   ,0    ,15   ,22   ,16   ,14   ,23   ,40   ,22   ,52   ,19   ,28   ,15   ,19   ,30   ,21   ,33   ,21   ,12   ,23   ,16   ,25   ,60   ,21   ,20   ],//5-CasaPueblo
		 [6    ,11   ,5    ,4    ,14   ,0    ,12   ,11   ,1    ,18   ,28   ,18   ,43   ,16   ,17   ,2    ,11   ,18   ,12   ,21   ,14   ,6    ,19   ,10   ,14   ,48   ,17   ,12   ],//6-Catedral San Fernando
		 [7    ,4    ,8    ,11   ,23   ,13   ,0    ,10   ,13   ,15   ,23   ,15   ,37   ,12   ,11   ,14   ,5    ,13   ,19   ,16   ,15   ,13   ,15   ,8    ,8    ,43   ,15   ,7    ],//7-Centro de Convenciones
		 [9    ,8    ,9    ,11   ,17   ,13   ,10   ,0    ,11   ,10   ,26   ,10   ,41   ,7    ,15   ,12   ,8    ,16   ,10   ,19   ,8    ,10   ,10   ,5    ,12   ,46   ,9    ,7    ],//8-Conrad
		 [6    ,11   ,5    ,2    ,14   ,1    ,11   ,11   ,0    ,17   ,28   ,17   ,42   ,15   ,17   ,4    ,10   ,18   ,11   ,21   ,14   ,5    ,18   ,9    ,14   ,48   ,16   ,11   ],//9-Cuartel de Dragones
		 [15   ,13   ,15   ,18   ,24   ,20   ,15   ,8    ,18   ,0    ,29   ,2    ,44   ,5    ,18   ,19   ,14   ,19   ,15   ,22   ,4    ,17   ,5    ,11   ,15   ,49   ,6    ,12   ],//10-Faro Punta del Este
		 [23   ,22   ,23   ,27   ,39   ,29   ,22   ,25   ,29   ,30   ,0    ,29   ,22   ,26   ,11   ,29   ,24   ,10   ,23   ,8    ,27   ,29   ,30   ,25   ,14   ,29   ,29   ,24   ],//11-Pablo Atchugarry
		 [14   ,13   ,15   ,18   ,24   ,20   ,15   ,8    ,18   ,2    ,29   ,0    ,44   ,5    ,17   ,19   ,13   ,19   ,15   ,22   ,5    ,17   ,5    ,11   ,14   ,49   ,8    ,12   ],//12-Iglecia Candelaria
		 [39   ,37   ,38   ,41   ,54   ,43   ,36   ,40   ,43   ,44   ,23   ,43   ,0    ,41   ,30   ,43   ,38   ,24   ,37   ,22   ,43   ,42   ,44   ,27   ,9    ,44   ,40   ,38   ],//13-Jose Ignacio
		 [9    ,8    ,10   ,13   ,19   ,15   ,10   ,4    ,13   ,7    ,24   ,6    ,39   ,0    ,13   ,14   ,8    ,14   ,10   ,17   ,5    ,12   ,7    ,6    ,10   ,45   ,6    ,7    ],//14-Los Dedos
		 [13   ,11   ,13   ,16   ,28   ,18   ,11   ,14   ,19   ,18   ,11   ,18   ,30   ,15   ,0    ,18   ,13   ,7    ,12   ,9    ,16   ,18   ,18   ,15   ,3    ,36   ,18   ,13   ],//15-Museo del Mar
		 [7    ,10   ,6    ,5    ,17   ,2    ,12   ,13   ,4    ,19   ,29   ,19   ,43   ,16   ,17   ,0    ,12   ,19   ,11   ,22   ,17   ,8    ,19   ,11   ,14   ,49   ,18   ,13   ],//16-Museo Mazzoni
		 [7    ,5    ,8    ,11   ,20   ,13   ,5    ,8    ,13   ,14   ,25   ,13   ,39   ,11   ,13   ,13   ,0    ,15   ,4    ,18   ,12   ,12   ,14   ,6    ,10   ,45   ,14   ,5    ],//17-Museo Ralli
		 [14   ,12   ,14   ,18   ,30   ,20   ,13   ,16   ,20   ,20   ,10   ,20   ,23   ,17   ,7    ,20   ,15   ,0    ,14   ,3    ,18   ,20   ,20   ,16   ,5    ,30   ,20   ,15   ],//18-La Barra Shopping Oh
		 [6    ,4    ,8    ,12   ,23   ,13   ,17   ,10   ,14   ,16   ,24   ,15   ,38   ,13   ,13   ,14   ,5    ,14   ,0    ,18   ,14   ,14   ,16   ,8    ,10   ,45   ,15   ,7    ],//19-Jaguel
		 [17   ,15   ,17   ,22   ,34   ,23   ,16   ,19   ,24   ,23   ,8    ,23   ,21   ,20   ,10   ,24   ,18   ,4    ,17   ,0    ,21   ,24   ,23   ,20   ,8    ,29   ,23   ,18   ],//20-Playa Bikini
		 [12   ,10   ,13   ,16   ,18   ,18   ,13   ,7    ,16   ,4    ,27   ,3    ,41   ,3    ,16   ,17   ,11   ,18   ,13   ,21   ,0    ,14   ,4    ,13   ,48   ,10   ,9    ,10   ],//21-Plaza Artigas
		 [6    ,10   ,5    ,6    ,13   ,6    ,12   ,10   ,5    ,16   ,30   ,15   ,43   ,14   ,17   ,9    ,11   ,20   ,11   ,23   ,15   ,0    ,16   ,9    ,14   ,51   ,14   ,12   ],//22-Torre del Vigia
		 [15   ,13   ,16   ,18   ,23   ,19   ,15   ,8    ,18   ,6    ,31   ,5    ,45   ,5    ,19   ,19   ,13   ,21   ,15   ,24   ,5    ,16   ,0    ,11   ,15   ,52   ,4    ,12   ],//23-Plazoleta Gran Bretaña	taba despues de este shopping
		 [7    ,4    ,8    ,11   ,19   ,12   ,7    ,5    ,11   ,10   ,23   ,10   ,29   ,7    ,12   ,12   ,6    ,13   ,7    ,16   ,13   ,11   ,10   ,0    ,9    ,44   ,10   ,4    ],//24-Puente de la Barra
		 [10   ,8    ,10   ,14   ,26   ,15   ,8    ,14   ,16   ,18   ,16   ,18   ,9    ,15   ,4    ,16   ,10   ,6    ,10   ,9    ,50   ,16   ,18   ,15   ,0    ,37   ,18   ,13   ],//25-Puente Garzon
		 [45   ,43   ,44   ,49   ,60   ,51   ,43   ,49   ,51   ,53   ,30   ,53   ,46   ,50   ,37   ,51   ,45   ,32   ,45   ,30   ,11   ,51   ,54   ,49   ,36   ,0    ,53   ,47   ],//26-Puerto Punta del Este
		 [15   ,13   ,16   ,19   ,24   ,19   ,16   ,8    ,18   ,7    ,29   ,9    ,40   ,6    ,18   ,18   ,15   ,19   ,16   ,22   ,10   ,18   ,4    ,12   ,15   ,50   ,0    ,13   ],//27-Punta Shopping		cambie de lugar cuidado
		 [8    ,4    ,9    ,11   ,22   ,13   ,6    ,7    ,12   ,12   ,24   ,12   ,39   ,10   ,13   ,14   ,4    ,14   ,6    ,17   ,11   ,12   ,13   ,5    ,10   ,44   ,12   ,0    ],//28-San Rafael		mal??
		 ];
								//Paradas a sonas de interes kilometros
var PIK=[[23.5 ,20.9 ,23.9 ,20   ,22.2 ,20   ,21.9 ,20.3 ,20.5 ,22.8 ,20.7 ,22.4 ,21.7 ,20.8 ,23.3 ,20.7 ,],//aeropueto punta del este
		 [4.6  ,1.5  ,5.6  ,1.5  ,2    ,1.6  ,1.5  ,1.1  ,1    ,2.1  ,1.8  ,2.2  ,1.4  ,1.4  ,5.3  ,2.5  ,],//taxi barrio norte
		 [4.6  ,3.2  ,5.7  ,3.7  ,3.7  ,3.8  ,3.7  ,3.2  ,2.4  ,3.8  ,3.9  ,4.8  ,3.5  ,3.1  ,5.4  ,4.6  ,],//taxi birritz
		 [1.2  ,3.7  ,1.1  ,3.4  ,2.7  ,3.5  ,3    ,3.5  ,3.5  ,2.7  ,3.6  ,2.3  ,3.1  ,3.5  ,0    ,2.9  ,],//taxi cantegril
		 [5    ,6.7  ,3.3  ,7.1  ,6.1  ,7.1  ,6.8  ,7.2  ,7.3  ,6.5  ,7.2  ,6.2  ,6.7  ,6.6  ,3.9  ,6.3  ,],//taxi nogaro
		 [2.4  ,0.24 ,4    ,0.65 ,1.3  ,0.7  ,0.65 ,0.5  ,1.3  ,1.3  ,0.8  ,1.3  ,0.5  ,0.65 ,3.4  ,1.1  ,],//taxi colonial
		 [5.5  ,7.9  ,3.7  ,7.6  ,6.6  ,7.6  ,7.3  ,7.7  ,7.8  ,7.1  ,7.7  ,6.7  ,7.2  ,7.8  ,4.4  ,6.8  ,],//taxi la fragata
		 [2.9  ,1.4  ,4.5  ,0.65 ,1.9  ,0.65 ,1.3  ,1    ,2    ,2    ,0.22 ,2    ,1.1  ,1.3  ,3.9  ,1.3  ,],//hospital maldonado BUS(0610)
		 [5.9  ,7.6  ,4.1  ,7.9  ,6.9  ,8    ,7.7  ,8    ,8.2  ,7.4  ,8.1  ,7    ,7.6  ,7.5  ,4.8  ,7.2  ,],//lafayette BUS 0078
		 [10.2 ,11.1 ,10.5 ,11.6 ,10   ,11.6 ,10.5 ,11.1 ,10.6 ,10.3 ,11.7 ,10.4 ,10.8 ,11   ,11.8 ,10.8 ,],//la barra taxi
		 [5.5  ,4.6  ,7    ,3.7  ,4.8  ,3.7  ,4.5  ,4    ,4.2  ,4.9  ,3.8  ,4.6  ,4.4  ,4.5  ,6.4  ,3.9  ,],//taxi lausana
		 [3.7  ,2.3  ,4.8  ,2.8  ,2.8  ,2.8  ,2.8  ,2.3  ,1.5  ,2.9  ,2.9  ,3.9  ,9    ,2.2  ,4.4  ,4.2  ,],//parada de taxi maldonado nuevo
		 [2.3  ,0.3  ,4.1  ,0.75 ,1    ,0.8  ,0.35 ,0.7  ,1.4  ,1    ,0.95 ,1    ,0.22 ,0.75 ,3.5  ,1.2  ,],//Centro maldonado Marco De Los Reyes
		 [5.2  ,6.9  ,3.4  ,7.2  ,6.2  ,7.2  ,6.9  ,7.3  ,7.5  ,6.7  ,7.4  ,6.3  ,6.8  ,6.8  ,4    ,6.5  ,],//oasis Heladería El Faro
		 [3.3  ,5.7  ,1.5  ,5.5  ,4.7  ,5.5  ,5.2  ,6.1  ,5.6  ,5.1  ,5.7  ,4.4  ,5.1  ,5.6  ,2.2  ,5    ,],//taxi punta shopping
		 [1.5  ,1.8  ,3.1  ,1.2  ,1.1  ,1.2  ,1.3  ,1.6  ,2.3  ,1    ,1.3  ,0.65 ,1.2  ,1.7  ,2.5  ,0    ,],//Taxi Mautone
		 [5.1  ,6.8  ,3.3  ,7.3  ,5.8  ,7.3  ,6.4  ,7.2  ,6.8  ,6.2  ,7.4  ,6    ,6.9  ,6.7  ,3.9  ,6.8  ,],//san rafael BUS - (0231)
		 [1.6  ,1.5  ,2.9  ,1.6  ,0.8  ,1.6  ,1    ,1.7  ,2.2  ,0.7  ,1.7  ,0.3  ,1.2  ,1.4  ,2.3  ,1    ,],//Taxi Terminal Maldonado
		 [4.7  ,6.6  ,2.9  ,7    ,5.9  ,7    ,6.7  ,7    ,7    ,6.4  ,7.1  ,6.1  ,6.6  ,7    ,3.5  ,6.2  ,],//COT - Terminal Punta del Este
		 ];
								//Paradas a sonas de interes tiempo minutos
var PIT=[[22   ,24   ,24   ,21   ,24   ,22   ,23   ,23   ,24   ,23   ,21   ,21   ,22   ,25   ,24   ,20   ,],//aeropueto parada
		 [10   ,5    ,10   ,5    ,7    ,5    ,6    ,4    ,3    ,7    ,6    ,8    ,5    ,4    ,12   ,8    ,],//taxi barrio norte
		 [10   ,9    ,11   ,10   ,11   ,10   ,12   ,9    ,6    ,11   ,11   ,11   ,11   ,8    ,12   ,14   ,],//taxi birritz
		 [2    ,9    ,2    ,8    ,7    ,10   ,9    ,9    ,9    ,8    ,9    ,6    ,8    ,9    ,0    ,7    ,],//taxi cantegril
		 [10   ,15   ,7    ,14   ,13   ,14   ,14   ,14   ,15   ,13   ,14   ,11   ,13   ,15   ,9    ,11   ,],//taxi nogaro
		 [8    ,3    ,10   ,3    ,5    ,3    ,3    ,2    ,5    ,5    ,3    ,5    ,3    ,3    ,10   ,4    ,],//taxi colonial
		 [11   ,17   ,9    ,16   ,15   ,16   ,15   ,16   ,16   ,15   ,17   ,13   ,15   ,16   ,10   ,14   ,],//taxi la fragata
		 [9    ,6    ,11   ,3    ,7    ,3    ,5    ,4    ,6    ,7    ,1    ,7    ,5    ,5    ,11   ,4    ,],//hospital maldonado BUS(0610)
		 [12   ,18   ,9    ,16   ,15   ,16   ,16   ,16   ,17   ,15   ,17   ,13   ,15   ,17   ,11   ,14   ,],//lafayette BUS 0078
		 [17   ,18   ,16   ,20   ,17   ,20   ,19   ,18   ,16   ,17   ,21   ,18   ,20   ,18   ,17   ,19   ,],//la barra taxi
		 [11   ,11   ,14   ,7    ,11   ,7    ,10   ,8    ,9    ,11   ,8    ,9    ,11   ,10   ,14   ,7    ,],//taxi lausana
		 [8    ,7    ,9    ,9    ,9    ,9    ,9    ,7    ,5    ,9    ,9    ,9    ,2.6  ,6    ,10   ,11   ,],//parada de taxi maldonado nuevo
		 [7    ,4    ,10   ,4    ,5    ,4    ,2    ,3    ,5    ,5    ,4    ,4    ,2    ,4    ,11   ,5    ,],//Centro maldonado Marco De Los Reyes
		 [10   ,16   ,8    ,14   ,13   ,14   ,14   ,14   ,15   ,13   ,15   ,11   ,14   ,16   ,9    ,12   ,],//oasis Heladería El Faro
		 [6    ,12   ,3    ,12   ,10   ,14   ,12   ,13   ,11   ,11   ,14   ,10   ,13   ,12   ,6    ,11   ,],//taxi punta shopping//
		 [4    ,7    ,7    ,4    ,5    ,4    ,5    ,5    ,7    ,3    ,5    ,2    ,4    ,6    ,7    ,0    ,],//Taxi Mautone
		 [9    ,15   ,7    ,16   ,13   ,17   ,16   ,17   ,14   ,14   ,17   ,13   ,16   ,15   ,9    ,15   ,],//san rafael BUS - (0231)
		 [5    ,6    ,7    ,6    ,4    ,6    ,4    ,6    ,7    ,3    ,7    ,1    ,5    ,5    ,8    ,4    ,],//Taxi Terminal Maldonado
		 [9    ,15   ,6    ,13   ,13   ,14   ,13   ,14   ,14   ,12   ,14   ,10   ,12   ,14   ,7    ,11   ,],//COT - Terminal Punta del Este
		 ];
$(document).ready(function(){
	$(".aParadas").click(ParadaSeleccionada);
	$(".aTuristicas").click(TuristicaSeleccionanda);
	$(".aInteres").click(InteresSeleccionando);
	$("#aCostoTiempo").click(CostoTiempo);
	$("#aPropioViaje").click(CreeSuViaje);
	$("#aInicio").click(Patronal);
	$("#aConfigurar").click(Configurar);
	$("#btnPrecio").click(CambiarValor);
	$("#btnViaje").click(CrearViaje);
	CambiarMenu();
	RecetearValores();
	$("#Inicio").show();
});
function CrearViaje(){
	$("#divRes").show();
	$("#pRes").hide();
	$("#tbyRes").hide();
	$("#hRes").hide();
	var lugaresAVisitar=[];
	var precioTotal=0;
	var tiempoTotal=0;
	var primera=true;
	var porParadas=true;
	var cercano;
	var tiempo;
	var lugar;
	var visitado;
	var posicion=$("#posicion").val();
	for(var i=0;i<28;i++){
		if($("#box"+i).is(":checked"))
			lugaresAVisitar.push(i);
	}
	if(lugaresAVisitar.length==0){
		$("#pRes").show();
		$("#tbeRes").hide();
	}
	else{
		$("#pRes").hide();
		$("#tbeRes").show();
		$("#tbyRes").show();
		$("#hRes").show();
		$("#tbyRes").html("");
		while(lugaresAVisitar.length>0){
			for(var l=0;l<lugaresAVisitar.length;l++){
				if(porParadas){
					if(l==0){
						cercano=PZK[posicion][lugaresAVisitar[l]];
						lugar=lugaresAVisitar[l];
						visitado=l;
						tiempo=PZT[posicion][lugaresAVisitar[l]]
					}
					else{
						if(PZK[posicion][lugaresAVisitar[l]]<cercano){
							cercano=PZK[posicion][lugaresAVisitar[l]];
							lugar=lugaresAVisitar[l];
							visitado=l;
							tiempo=PZT[posicion][lugaresAVisitar[l]]
						}
					}
				}
				else{
					if(l==0){
						cercano=ZZK[posicion][lugaresAVisitar[l]];
						lugar=lugaresAVisitar[l];
						visitado=l;
						tiempo=ZZT[posicion][lugaresAVisitar[l]]
					}
					else{
						if(ZZK[posicion][lugaresAVisitar[l]]<cercano){
							cercano=ZZK[posicion][lugaresAVisitar[l]];
							lugar=lugaresAVisitar[l];
							visitado=l;
							tiempo=ZZT[posicion][lugaresAVisitar[l]]
						}
					}
				}
			}
			porParadas=false;
			if(primera){
				$("#tbyRes").append('<tr><td>'+paradas[posicion]+'</td><td>'+turisticas[lugar]+'</td><td>'+parseInt(cercano*precio)+'</td><td>'+tiempo+'</td></tr>');
				primera=false;
			}
			else
				$("#tbyRes").append('<tr><td>'+turisticas[posicion]+'</td><td>'+turisticas[lugar]+'</td><td>'+parseInt(cercano*precio)+'</td><td>'+tiempo+'</td></tr>');
			lugaresAVisitar.splice(visitado,1);
			posicion=lugar;
			precioTotal+=parseInt(cercano*precio);
			tiempoTotal+=tiempo;
		}
		$("#hRes").html("El precio total es de: "+precioTotal+"$ y el viaje tardara: "+tiempoTotal+" minutos");
	}
}
function Configurar(){
	CambiarMenu();
	$("#Configurar").show();
}
function CambiarValor(){
	precio=$("#precio").val();
	$("#costoKilometros").html(precio);
	$("#precio").val("");
	RecetearValores();
}
function CreeSuViaje(){
	CambiarMenu();
	$("#divRes").hide();
	$("#PropioViaje").show();
}
function Patronal(){
	CambiarMenu();
	$("#Inicio").show();
}
function CrearTablaParadas(){
	var precioDia;
	var precioNoche;
	for(var i=0;i<19;i++){
		$("#tbyp"+i).html("");
		for(var l=0;l<28;l++){
			precioDia=parseInt(PZK[i][l]*precio);
			precioNoche=parseInt((PZK[i][l]*precio)+((PZK[i][l]*precio)*0.2));
			if(precioDia<40&&precioDia!=0)
				precioDia=40;
			if(precioNoche<40&&precioNoche!=0)
				precioNoche=40;
			$("#tbyp"+i).append('<tr><td>'+turisticas[l]+'</td><td>'+precioDia+'</td><td>'+precioNoche+'</td><td>'+PZT[i][l]+" minutos"+'</td></tr>');
		}
	}
}
function CrearTablaZonas(){
	var precioDia;
	var precioNoche;
	for(var i=0;i<14;i++){
		$("#tbyz"+i).html("");
		for(var l=0;l<19;l++){
			precioDia=parseInt(PZK[l][i]*precio);
			precioNoche=parseInt((PZK[l][i]*precio)+((PZK[l][i]*precio)*0.2));
			if(precioDia<40&&precioDia!=0)
				precioDia=40;
			if(precioNoche<40&&precioNoche!=0)
				precioNoche=40;	
			$("#tbyz"+i).append('<tr><td>'+paradas[l]+'</td><td>'+precioDia+'</td><td>'+precioNoche+'</td><td>'+PZT[l][i]+" minutos"+'</td></tr>');
		}
	}
}
function CrearTablaInteres(){
	var precioDia;
	var precioNoche;
	for(var i=0;i<28;i++){
		$("#tbyi"+i).html("");
		for(var l=0;l<19;l++){
			precioDia=parseInt(PIK[l][i]*precio);
			precioNoche=parseInt((PIK[l][i]*precio)+((PIK[l][i]*precio)*0.2));
			if(precioDia<40&&precioDia!=0)
				precioDia=40;
			if(precioNoche<40&&precioNoche!=0)
				precioNoche=40;
			$("#tbyi"+i).append('<tr><td>'+paradas[l]+'</td><td>'+precioDia+'</td><td>'+precioNoche+'</td><td>'+PIT[l][i]+" minutos"+'</td></tr>');
		}
	}
}
function CrearTablaGeneral(){
	$("#tblGeneralCosto").html("");
	$("#tblGeneralTiempo").html("");
	var tabla="<tr><th>Zonas Turisticas</th>";
	var tabla2="<tr><th>Zonas Turisticas</th>";
	for(var i=0;i<28;i++){
		tabla+="<th>"+turisticas[i]+"</th>";
		tabla2+="<th>"+turisticas[i]+"</th>";
	}
	tabla+="</tr>";
	tabla2+="</tr>";
	for(var i=0;i<28;i++){
		tabla+="<tr><th>"+turisticas[i]+"</th>";
		tabla2+="<tr><th>"+turisticas[i]+"</th>";
		for(var l=0;l<28;l++){
			tabla+="<td>"+parseInt(ZZK[i][l]*precio)+"</td>";
			tabla2+="<td>"+ZZT[i][l]+"</td>";
		}
		tabla+="</tr>";
		tabla2+="</tr>";
	}
	$("#tblGeneralCosto").html(tabla);
	$("#tblGeneralTiempo").html(tabla2);
}
function RecetearValores(){
	CrearTablaParadas();
	CrearTablaZonas();
	CrearTablaGeneral();
	CrearTablaInteres();
}
function InteresSeleccionando(){
	CambiarMenu();
	$("#Zonas\\ de\\ Interes").show();
	switch($(this).attr("id")){
		case "aAsociacion Espanola":
			$("#Asociacion\\ Espanola").show();
			break;
		case "aBanco de Seguros":
			$("#Banco\\ de\\ Seguros").show();
			break;
		case "aBlue Cross and Blue Shield":
			$("#Blue\\ Cross\\ and\\ Blue\\ Shield").show();
			break;
		case "aCasmu":
			$("#Casmu").show();
			break;
		case "aCampus Municipal":
			$("#Campus\\ Municipal").show();
			break;
		case "aCeter":
			$("#Ceter").show();
			break;
		case "aConsulado Argentino":
			$("#Consulado\\ Argentino").show();
			break;
		case "aCorreo":
			$("#Correo").show();
			break;
		case "aCredencial":
			$("#Credencial").show();
			break;
		case "aDNIC":
			$("#DNIC").show();
			break;
		case "aHospital":
			$("#Hospital").show();
			break;
		case "aIntendencia Municipal de Maldonado":
			$("#Intendencia\\ Municipal\\ de\\ Maldonado").show();
			break;
		case "aJefatura":
			$("#Jefatura").show();
			break;
		case "aMigraciones":
			$("#Migraciones").show();
			break;
		case "aSanatorio Cantegril":
			$("#Sanatorio\\ Cantegril").show();
			break;
		case "aSanatorio Mautones":
			$("#Sanatorio\\ Mautones").show();
			break;
		
	}
}
function TuristicaSeleccionanda(){
	CambiarMenu();
	$("#Zonas\\ Turisticas").show();
	switch($(this).attr("id")){
		case "aAzotea de Haedo":
			$("#Azotea\\ de\\ Haedo").show();
			break;
		case "aBeverly Hills":
			$("#Beverly\\ Hills").show();
			break;
		case "aCachimba del Rey":
			$("#Cachimba\\ del\\ Rey").show();
			break;
		case "aCasa de la Cultura":
			$("#Casa\\ de\\ la\\ Cultura").show();
			break;
		case "aCasa Pueblo":
			$("#Casa\\ Pueblo").show();
			break;
		case "aCatedral San Fernando":
			$("#Catedral\\ San\\ Fernando").show();
			break;
		case "aCentro de Convenciones":
			$("#Centro\\ de\\ Convenciones").show();
			break;
		case "aConrad":
			$("#Conrad").show();
			break;
		case "aCuartel de Dragones":
			$("#Cuartel\\ de\\ Dragones").show();
			break;
		case "aFaro Punta del Este":
			$("#Faro\\ Punta\\ del\\ Este ").show();
			break;
		case "aFundacion Pablo Atchugarry":
			$("#Fundacion\\ Pablo\\ Atchugarry").show();
			break;
		case "aIglesia de la Candelaria":
			$("#Iglesia\\ de\\ la\\ Candelaria").show();
			break;
		case "aJose Ignacio":
			$("#Jose\\ Ignacio").show();
			break;	
		case "aLos Dedos":
			$("#Los\\ Dedos").show();
			break;
		case "aMuseo del Mar":
			$("#Museo\\ del\\ Mar").show();
			break;
		case "aMuseo Mazzoni":
			$("#Museo\\ Mazzoni").show();
			break;
		case "aMuseo Ralli":
			$("#Museo\\ Ralli").show();
			break;
		case "aOh La Barra":
			$("#Oh\\ La\\ Barra").show();
			break;	
		case "aParque Jaguel":
			$("#Parque\\ Jaguel").show();
			break;
		case "aPlaya Bikini":
			$("#Playa\\ Bikini").show();
			break;
		case "aPlaza Artigas":
			$("#Plaza\\ Artigas").show();
			break;
		case "aTorre del Vigia":
			$("#Torre\\ del\\ Vigia").show();
			break;
		case "aPlazoleta Gran Bretaña":
			$("#Plazoleta\\ Gran\\ Bretaña").show();
			break;
			case "aPunta Shopping":
			$("#Punta\\ Shopping").show();
			break;
		case "aPuente de la Barra":
			$("#Puente\\ de\\ la\\ Barra").show();
			break;
		case "aPuente Garzon":
			$("#Puente\\ Garzon ").show();
			break;			
		case "aPuerto de Punta del Este":
			$("#Puerto\\ de\\ Punta\\ del\\ Este").show();
			break;
		case "aSan Rafael":
			$("#San\\ Rafael").show();
			break;
	}
}
function ParadaSeleccionada(){
	CambiarMenu();
	$("#Paradas").show();
	switch($(this).attr("id")){
		case "aFragata":
			$("#Fragata").show();		
			break;
		case "aCantegril":
			$("#Cantegril").show();
			break;
		case "aLafayette":
			$("#Lafayette").show();
			break;
		case "aBarrio Norte":
			$("#Barrio\\ Norte").show();
			break;
		case "aColonial":
			$("#Colonial").show();
			break;
		case "aHospital Maldonado":
			$("#Hospital\\ Maldonado").show();
			break;
		case "aLa Barra":
			$("#La\\ Barra").show();
			break;
		case "aMaldonado Nuevo":
			$("#Maldonado\\ Nuevo").show();
			break;
		case "aMarco de los Reyes":
			$("#Marco\\ de\\ los\\ Reyes").show();
			break;
		case "aTerminal de Maldonado":
			$("#Terminal\\ de\\ Maldonado").show();
			break;
		case "aOasis":
			$("#Oasis").show();
			break;
		case "aSan Rafael":
			$("#San\\ Rafael").show();
			break;
		case "aTerminal Punta del Este":
			$("#Terminal\\ Punta\\ del\\ Este").show();
			break;
		case "aCasino Nogaro":
			$("#Casino\\ Nogaro").show();
			break;
		case "aPunta Shopping taxi":
			$("#Punta\\ Shopping\\ taxi").show();
			break;
		case "aSanatorio Mautone taxi":
			$("#Sanatorio\\ Mautone\\ taxi").show();
			break;
		case "aLausana":
			$("#Lausana").show();
			break;
		case "aBiarriz":
			$("#Biarriz").show();
			break;
		case "aAeropuerto taxi":
			$("#Aeropuerto\\ taxi").show();
			break;
	}
	
}
function CostoTiempo(){
	CambiarMenu();
	$("#Costos\\ de\\ traslado\\ y\\ tiempo").show();
}
function CambiarMenu(){
	$("#respuesta").html("");
	$("#Inicio").hide();
	$("#Paradas").hide();
	$("#Zonas\\ Turisticas").hide();
	$("#Costos\\ de\\ traslado\\ y\\ tiempo").hide();
	$("#Zonas\\ de \\Interes").hide();
	$("#PropioViaje").hide();
	$(".divParadas").hide();
	$(".divTuristicas").hide();
	$(".divInteres").hide();
	$("#Configurar").hide();
}