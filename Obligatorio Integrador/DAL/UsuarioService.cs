using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class UsuarioService
    {
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
                    Articulo fresa = db.articulos.Add(new Articulo() { activo = true, descripcion = "Fresa", iva = 21, miniStock = 70, precioVenta = 100 });
                    db.registro.Add(new Registro() { articulo = fresa, cambio = 100, fecha = DateTime.Today });
                    Articulo melon = db.articulos.Add(new Articulo() { activo = true, descripcion = "Melon", iva = 21, miniStock = 72, precioVenta = 75 });
                    db.registro.Add(new Registro() { articulo = melon, cambio = 100, fecha = DateTime.Today });
                    Articulo sandia = db.articulos.Add(new Articulo() { activo = true, descripcion = "Sandia", iva = 21, miniStock = 70, precioVenta = 70 });
                    db.registro.Add(new Registro() { articulo = sandia, cambio = 100, fecha = DateTime.Today });
                    Articulo uva = db.articulos.Add(new Articulo() { activo = true, descripcion = "Uva", iva = 21, miniStock = 100, precioVenta = 88 });
                    db.registro.Add(new Registro() { articulo = uva, cambio = 122, fecha = DateTime.Today });
                    Articulo mango = db.articulos.Add(new Articulo() { activo = true, descripcion = "Mango", iva = 21, miniStock = 90, precioVenta = 67 });
                    db.registro.Add(new Registro() { articulo = mango, cambio = 100, fecha = DateTime.Today });
                    Articulo coca = db.articulos.Add(new Articulo() { activo = true, descripcion = "Coca", iva = 10, miniStock = 100, precioVenta = 60 });
                    db.registro.Add(new Registro() { articulo = coca, cambio = 0, fecha = DateTime.Today });
                    Articulo fanta = db.articulos.Add(new Articulo() { activo = true, descripcion = "Fanta", iva = 10, miniStock = 110, precioVenta = 40 });
                    db.registro.Add(new Registro() { articulo = fanta, cambio = 0, fecha = DateTime.Today });
                    Articulo pepsi = db.articulos.Add(new Articulo() { activo = true, descripcion = "Pepsi", iva = 10, miniStock = 130, precioVenta = 80 });
                    db.registro.Add(new Registro() { articulo = pepsi, cambio = 0, fecha = DateTime.Today });
                    //proveedores y sus contactos
                    Proveedor lautaro = db.proveedores.Add(new Proveedor() { activo=true,descripcion="Empresa Lautaro",nombre="Lautaro",rut="123"});
                    db.contactos.Add(new Contacto() { nombre="Lauta",telefono=097987654,proveedor=lautaro});
                    db.contactos.Add(new Contacto() { nombre = "Tito", telefono = 097787678, proveedor = lautaro });
                    db.contactos.Add(new Contacto() { nombre = "Paula", telefono = 099654532, proveedor = lautaro });
                    Proveedor tomatoma = db.proveedores.Add(new Proveedor() { activo = true, descripcion = "Empresa Toma Toma", nombre = "toma", rut = "454" });
                    db.contactos.Add(new Contacto() { nombre = "Miguel", telefono = 099213412, proveedor = tomatoma });
                    db.contactos.Add(new Contacto() { nombre = "Felix", telefono = 099884433, proveedor = tomatoma });
                    Proveedor frutifruti = db.proveedores.Add(new Proveedor() { activo = true, descripcion = "Empresa Fruti Fruti", nombre = "fruti", rut = "444" });
                    //articulos de un proveedor
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = fresa, proveedor = frutifruti, costo = 80, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = fresa, proveedor = frutifruti, costo = 60, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = fresa, proveedor = frutifruti, costo = 70, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = melon, proveedor = frutifruti, costo = 50, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = sandia, proveedor = frutifruti, costo = 50, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = uva, proveedor = frutifruti, costo = 80, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = mango, proveedor = frutifruti, costo = 60, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });

                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = coca, proveedor = tomatoma, costo = 40, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = coca, proveedor = tomatoma, costo = 38, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = fanta, proveedor = tomatoma, costo = 20, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.articuloProveedores.Add(new ArticuloProveedor() { articulo = pepsi, proveedor = tomatoma, costo = 40, fecha = DateTime.Today.AddHours(DateTime.Today.Hour) });
                    db.SaveChanges();
                }
            }
        }
    }
}
