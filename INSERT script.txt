Insert into MARCA(ID, Descripcion) values ( 'Coca' , 'Coca Cola') ,('Pepsi', 'Pepsi'), ('Lays', 'Lays'), ('Quilmes', 'Quilmes'), ('Donsa', 'Don Satur')

Insert into PROVEEDOR(ID, Descripcion, CUIT,Telefono, Mail) values ('Pepsi', 'Pepsico', '30151530303', '1174748383', 'ventas@pepsico.com.ar'), ('Quilmes', 'Quilmes', '33202021210', '1517172525', 'distribucion@quilmes.com.ar'), ('Bagley', 'Bagley', '33747574753', '1189909089', 'ventas@mondelez.com.ar')

Insert into PRODUCTO(ID, Descripcion, ID_Marca, ID_Proveedor, Precio_Compra, Precio_Venta, Stock_Minimo) values ('Don grasa', 'Don Satur grasa', 'Donsa', 'Bagley', 30, 55, 20), ('Don dulce', 'Don Satur dulce', 'Donsa', 'Bagley', 30, 55, 20), ('Don negra', 'Don Satur negra', 'Donsa', 'Bagley', 30, 55, 10), ('Pepsi 2L', 'Pepsi 2L', 'Pepsi', 'Pepsi', 90, 150, 30), ('Lays 96g', 'Papas Lays 96grs', 'Lays', 'Pepsi', 100, 180, 15), ('Lays 120g', 'Papas Lays 120grs', 'Lays', 'Pepsi', 120, 210, 10)

Insert into VENDEDOR(ID, Nombre_Apellido, DNI, Telefono, Nivel_Permiso) values ('01', 'Emilio Borges', '20717273', '1119861986', 1), ('02', 'Silvia Ocampo', '22733733', '1144445555', 2)

Insert into CLIENTE(ID, Nombre_Apellido, DNI, Telefono) values ('Perez', 'Alfredo Perez', '25473473', '1521212121'), ('Perez2', 'Pedro Perez', '22899899', '1147724473'), ('Ariel', 'Ariel Llano', '30202021', '1145546123')