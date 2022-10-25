using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        public static implicit operator Pesos(double p)
        {
            Pesos peso = new Pesos(p);
            return peso;
        }
        public static explicit operator Dolar(Pesos p)
        {
            Dolar dolar= new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
            return dolar;
        }
        public static explicit operator Euro(Pesos p)
        {
            Dolar auxEquivalenteDolar = new Dolar(0);
            auxEquivalenteDolar = (Dolar)p;
            Euro euro = new Euro(0);
            euro = (Euro)auxEquivalenteDolar;
            return euro;
        }
        public static bool operator ==(Pesos p1, Pesos p2) 
        {
            return (p1.GetCantidad()==p2.GetCantidad());
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return (p.GetCantidad() == (Pesos)d);
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return (p.GetCantidad() == (Pesos)e);
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos auxPesos = new Pesos(0);
            auxPesos = (Pesos)d;
            return p.GetCantidad() + auxPesos.GetCantidad();
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos auxPesos = new Pesos(0);
            auxPesos = (Pesos)e;
            return p.GetCantidad() + auxPesos.GetCantidad();
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos auxPesos = new Pesos(0);
            auxPesos = (Pesos)d;
            return p.GetCantidad() - auxPesos.GetCantidad();
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos auxPesos = new Pesos(0);
            auxPesos = (Pesos)e;
            return p.GetCantidad() - auxPesos.GetCantidad();
        }
        public static void SetCotizacion(double cotizacion) 
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
    }
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro() 
        {
            Euro.cotizRespectoDolar = 1.08;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad,double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion() 
        {
            return Euro.cotizRespectoDolar;
        }
        public static implicit operator Euro(double e)
        {
            Euro euro = new Euro(e);
            return euro;
        }
        public static explicit operator Dolar(Euro e) 
        {
            Dolar dolar = new Dolar(e.GetCantidad()/Euro.GetCotizacion());
            return dolar;
        }
        public static explicit operator Pesos(Euro e)
        {
            Dolar auxEquivalenteDolar = new Dolar(0);
            auxEquivalenteDolar = (Dolar)e;
            Pesos peso = new Pesos(0);
            peso = (Pesos)auxEquivalenteDolar;
            return peso;
        }
        public static bool operator ==(Euro e1, Euro e2) 
        {
            return (e1.GetCantidad()==e2.GetCantidad());
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad() == (Euro)d);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return (e.GetCantidad() == (Euro)p);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro auxEuro = new Euro(0);
            auxEuro = (Euro)d;
            return e.GetCantidad() + auxEuro.GetCantidad();
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            Euro auxEuro = new Euro(0);
            auxEuro = (Euro)p;
            return e.GetCantidad() + auxEuro.GetCantidad();
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro auxEuro = new Euro(0);
            auxEuro = (Euro)d;
            return e.GetCantidad() - auxEuro.GetCantidad();
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            Euro auxEuro = new Euro(0);
            auxEuro = (Euro)p;
            return e.GetCantidad() - auxEuro.GetCantidad();
        }
        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
    }
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar() 
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad,double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad() 
        {
            return this.cantidad;
        }
        public static double GetCotizacion() 
        {
            return Dolar.cotizRespectoDolar;
        }
        public static implicit operator Dolar (double d) 
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }
        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro(d.GetCantidad()*Euro.GetCotizacion());
            return euro;
        }
        public static explicit operator Pesos(Dolar d)
        {
            Pesos peso = new Pesos(d.GetCantidad()*Pesos.GetCotizacion());
            return peso;
        }
        public static bool operator ==(Dolar d1, Dolar d2) 
        {
            return (d1.GetCantidad() == d2.GetCantidad());
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return (d.GetCantidad() == (Dolar)p);
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.GetCantidad() == (Dolar)e);
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static Dolar operator + (Dolar d, Pesos p) 
        {
            Dolar auxDolar = new Dolar(0);
            auxDolar = (Dolar)p;
            return d.GetCantidad() + auxDolar.GetCantidad();
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar auxDolar = new Dolar(0);
            auxDolar = (Dolar)e;
            return d.GetCantidad() + auxDolar.GetCantidad();
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar auxDolar = new Dolar(0);
            auxDolar = (Dolar)p;
            return d.GetCantidad() - auxDolar.GetCantidad();
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar auxDolar = new Dolar(0);
            auxDolar = (Dolar)e;
            return d.GetCantidad() - auxDolar.GetCantidad();
        }
    }
}
