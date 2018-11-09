using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class UsuarioService
    {
        private static UsuarioService instancia;
        public static UsuarioService Instancia()
        {
            if (instancia == null)
                instancia = new UsuarioService();
            return instancia;
        }
        public void Agregar(Usuario usuario) {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                db.usuarios.Add(usuario);
                db.SaveChanges();
            }
        }
        public List<Usuario> Lista() {
            List<Usuario> usuarios = new List<Usuario>();
            using (BarracaLuisContext db = new BarracaLuisContext()) {
                foreach (var u in db.usuarios) {
                    usuarios.Add(new Usuario() { mail = u.mail, contra = u.contra });
                }
            }
            return usuarios;
        }
        public void Modificar(Usuario usuario)
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                foreach (var u in db.usuarios)
                {
                    if (u.mail == usuario.mail)
                    {
                        u.contra = usuario.contra;
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
        public void Borrar(String mail) {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {      
                foreach (var u in db.usuarios)
                {
                    if (u.mail == mail) {
                        db.usuarios.Remove(u);
                        break;
                    }
                }
                db.SaveChanges();
            }
        }
        public void Datos_de_prueba()
        {
            using (BarracaLuisContext db = new BarracaLuisContext())
            {
                Usuario usuario = db.usuarios.Find("mauro@gmail.com");
                if (usuario == null)
                {
                    //usuario de prueba
                    db.usuarios.Add(new Usuario() { mail="mauro@gmail.com",contra="123"});
                    //articulos y registro inicial
                    Articulo hierro = db.articulos.Add(new Articulo() { activo = true, descripcion = "Hierro", iva = 21, miniStock = 70, precioVenta = 100 });
                    db.registro.Add(new Registro() { articulo = hierro, cambio = 0, fecha = DateTime.Today.AddYears(-3) });
                    Articulo malla = db.articulos.Add(new Articulo() { activo = true, descripcion = "Malla", iva = 21, miniStock = 72, precioVenta = 75 });
                    db.registro.Add(new Registro() { articulo = malla, cambio = 0, fecha = DateTime.Today.AddYears(-3) });
                    Articulo clavo = db.articulos.Add(new Articulo() { activo = true, descripcion = "Clavo", iva = 21, miniStock = 70, precioVenta = 70 });
                    db.registro.Add(new Registro() { articulo = clavo, cambio = 0, fecha = DateTime.Today.AddYears(-3) });
                    Articulo madera = db.articulos.Add(new Articulo() { activo = true, descripcion = "Madera", iva = 21, miniStock = 100, precioVenta = 88 });
                    db.registro.Add(new Registro() { articulo = madera, cambio = 0, fecha = DateTime.Today.AddYears(-3) });
                    Articulo baldosa = db.articulos.Add(new Articulo() { activo = true, descripcion = "Baldosa", iva = 21, miniStock = 90, precioVenta = 67 });
                    db.registro.Add(new Registro() { articulo = baldosa, cambio = 0, fecha = DateTime.Today.AddYears(-3) });
                    
                    Articulo pincel = db.articulos.Add(new Articulo() { activo = true, descripcion = "Pincel", iva = 10, miniStock = 100, precioVenta = 60 });
                    db.registro.Add(new Registro() { articulo = pincel, cambio = 0, fecha = DateTime.Today.AddYears(-3) });
                    Articulo rodillo = db.articulos.Add(new Articulo() { activo = true, descripcion = "Rodillo", iva = 10, miniStock = 110, precioVenta = 40 });
                    db.registro.Add(new Registro() { articulo = rodillo, cambio = 0, fecha = DateTime.Today.AddYears(-3) });
                    //proveedores y sus contactos
                    Proveedor lautaro = db.proveedores.Add(new Proveedor() { activo=true,descripcion="Empresa Lautaro",nombre="Lautaro",rut="123"});
                    db.contactos.Add(new Contacto() { nombre="Lauta",telefono=097987654,proveedor=lautaro});
                    db.contactos.Add(new Contacto() { nombre = "Tito", telefono = 097787678, proveedor = lautaro });
                    db.contactos.Add(new Contacto() { nombre = "Paula", telefono = 099654532, proveedor = lautaro });
                    Proveedor raul = db.proveedores.Add(new Proveedor() { activo = true, descripcion = "Obras Raul", nombre = "Raul", rut = "454" });
                    db.contactos.Add(new Contacto() { nombre = "Miguel", telefono = 099213412, proveedor = raul });
                    db.contactos.Add(new Contacto() { nombre = "Felix", telefono = 099884433, proveedor = raul });
                    Proveedor milton = db.proveedores.Add(new Proveedor() { activo = true, descripcion = "Pinturas Milton", nombre = "Milton", rut = "444" });
                    db.contactos.Add(new Contacto() { nombre = "Tito", telefono = 097654341, proveedor = milton });
                    //articulos del proveedor raul
                    ArticuloProveedor artPro1 = db.articuloProveedores.Add(new ArticuloProveedor() { articulo = hierro, proveedor = raul, costo = 80, fecha = DateTime.Today.AddYears(-2).AddMonths(-30) });
                    ArticuloProveedor artPro2 = db.articuloProveedores.Add(new ArticuloProveedor() { articulo = malla, proveedor = raul, costo = 60, fecha = DateTime.Today.AddYears(-2).AddMonths(-27) });
                    ArticuloProveedor artPro3 = db.articuloProveedores.Add(new ArticuloProveedor() { articulo = clavo, proveedor = raul, costo = 35, fecha = DateTime.Today.AddYears(-2).AddMonths(-16) });
                    ArticuloProveedor artPro4 = db.articuloProveedores.Add(new ArticuloProveedor() { articulo = madera, proveedor = raul, costo = 50, fecha = DateTime.Today.AddYears(-2).AddMonths(-19) });
                    ArticuloProveedor artPro5 = db.articuloProveedores.Add(new ArticuloProveedor() { articulo = baldosa, proveedor = raul, costo = 50, fecha = DateTime.Today.AddYears(-2).AddMonths(-17) });
                    //articulos del proveedor tomatoma
                    ArticuloProveedor artPro6 = db.articuloProveedores.Add(new ArticuloProveedor() { articulo = pincel, proveedor = milton, costo = 38, fecha = DateTime.Today.AddYears(-2).AddMonths(-22) });
                    ArticuloProveedor artPro7 = db.articuloProveedores.Add(new ArticuloProveedor() { articulo = rodillo, proveedor = milton, costo = 20, fecha = DateTime.Today.AddYears(-2).AddMonths(-10) });
                    //agrego facturas de compras con el cambio en el registro y las linea de compra

                    FacturaCompra fac1 = db.facturaCompras.Add(new FacturaCompra() { fecha= DateTime.Today.AddMonths(-30),proveedor=milton });
                    db.lineafacturas.Add(new LineaFactura() { cantidad = 40, factura = fac1, precio = 40*38, articulo= pincel });
                    db.registro.Add(new Registro() { articulo = pincel, cambio = 40, fecha = DateTime.Today.AddMonths(-30) });
                    db.lineafacturas.Add(new LineaFactura() { cantidad = 40, factura = fac1, precio = 40 * 20, articulo = rodillo });
                    db.registro.Add(new Registro() { articulo = rodillo, cambio = 40, fecha = DateTime.Today.AddMonths(-30) });

                    FacturaCompra fac2 = db.facturaCompras.Add(new FacturaCompra() { fecha = DateTime.Today.AddMonths(-30), proveedor = milton });
                    db.lineafacturas.Add(new LineaFactura() { cantidad = 80, factura = fac2, precio = 80 * 20, articulo = rodillo });
                    db.registro.Add(new Registro() { articulo = rodillo, cambio = 80, fecha = DateTime.Today.AddMonths(-30) });
                    

                    FacturaCompra fac3 = db.facturaCompras.Add(new FacturaCompra() { fecha = DateTime.Today.AddMonths(-20), proveedor = milton });
                    db.lineafacturas.Add(new LineaFactura() { cantidad = 100, factura = fac3, precio = 100 * 20, articulo = rodillo });
                    db.registro.Add(new Registro() { articulo = rodillo, cambio = 100, fecha = DateTime.Today.AddMonths(-20) });

                    FacturaVenta fac4 = db.facturasVentas.Add(new FacturaVenta() { fecha= DateTime.Today.AddMonths(-19),descripcion="Caceres"});
                    db.lineafacturas.Add(new LineaFactura() { cantidad = 180, factura = fac3, precio = 180 * 40, articulo = rodillo });
                    db.registro.Add(new Registro() { articulo = rodillo, cambio = -180, fecha = DateTime.Today.AddMonths(-19) });

                    FacturaCompra fac5 = db.facturaCompras.Add(new FacturaCompra() { fecha = DateTime.Today.AddMonths(-10), proveedor = milton });
                    db.lineafacturas.Add(new LineaFactura() { cantidad = 133, factura = fac5, precio = 133 * 20, articulo = rodillo });
                    db.registro.Add(new Registro() { articulo = rodillo, cambio = 133, fecha = DateTime.Today.AddMonths(-10) });
                    //grabamos los cambios
                    db.SaveChanges();
                }
            }
        }
    }
}
