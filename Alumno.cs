using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class Alumno : Persona
    {
        int legajo;
        double promedio;
        IEstrategiaDeComparacion estrategia;

        public Alumno(int l, double p, string n, int d) : base(n, d)   
        {
            this.legajo = l;
            this.promedio = p;
            estrategia = new CEstrategiaLegajo();
        }

        public void setEstrategia(IEstrategiaDeComparacion e)
        {
            estrategia = e;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio() 
        {
            return this.promedio;
        }

        public override bool sosIgual(IComparable c)
        {
            return estrategia.sosIgual(this, (Alumno)c);
        }
        public override bool sosMenor(IComparable c)
        {
            return estrategia.sosMenor(this, (Alumno)c);
        }
        public override bool sosMayor(IComparable c)
        {
            return estrategia.sosMayor(this, (Alumno)c);
        }

        public override string ToString()
        {
            return this.getNombre() + " | " + this.getLegajo() + " | " + this.getDni() + " | " + this.getPromedio()  + " | " + this.getEstrategia();
        }

        public string getEstrategia()
        {
            return estrategia.ToString();
        }
    }
}
