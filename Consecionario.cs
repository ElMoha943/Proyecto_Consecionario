using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consecionario
{
    class Consecionario
    {
        private Auto[] _Autos;
        private Moto[] _Motos;
        private Camion[] _Camiones;
        private int _numautos, _nummotos, _numcamiones;

        public Consecionario()
        {
            this._Autos = new Auto[5];
            this._Motos = new Moto[5];
            this._Camiones = new Camion[5];
            _numautos = 0;
            _nummotos = 0;
            _numcamiones = 0;
        }

        //METODOS
        public void AddCar(string tipo, string marca, string modelo, int km, double precio, bool airbag, bool seguro)
        {
            switch(tipo)
            {
                case "auto":
                    this._Autos[_numautos] = new Auto(_numautos, marca, modelo, km, precio, airbag, seguro);
                _numautos++;
                break;
                    
                case "moto":
                    this._Motos[_nummotos] = new Moto(_nummotos, marca, modelo, km, precio, seguro);
                    _nummotos++;
                    break;
                   
                case "camion":
                    this._Camiones[_numcamiones] = new Camion(_numcamiones, marca, modelo, km, precio, seguro);
                    _numcamiones++;
                    break;
            }
        }
        //public void RemoveCar(Coche c)
        //{
        //    int auxi = -1;
        //    if (c != null && _numCocches != 0)
        //    {
        //        for (int i = 0; i < _numCocches; i++)
        //        {
        //            if (c.Id == _coches[i].Id) //COMPARA EL ID DADO POR EL USUARIO CON LOS IDS DE LOS COCHES EN LA LISTA
        //            {
        //                auxi = i;
        //            }
        //        }
        //        if (auxi == -1)
        //        {
        //            Console.WriteLine("El coche no existe");
        //        }
        //        else
        //        {
        //            _coches[auxi] = null; //BORRA LA ENTRY
        //            for (int i = auxi; i < _numCocches; i++)
        //            {
        //                _coches[i] = _coches[i + 1]; //MUEVE TODAS LAS ENTRYS UNA POSICION ATRAS
        //            }
        //            _numCocches--;
        //        }
        //    }
        //}
        public void ClearCars(string tipo)
        {
            switch (tipo) 
            {
                case "auto":
                    this._Autos = new Auto[100];
                    _numautos = 0;
                    break;
                    
                case "moto":
                    this._Motos = new Moto[100];
                    _nummotos = 0;
                    break;
                   
                case "camion":
                    this._Camiones = new Camion[100];
                    _numcamiones = 0;
                    break;

            }
        }
        public object[] ShowCars(string tipo)
        {
            //switch (tipo)
            //{
            //    case "auto":
            //        for (int i = 0; i < _numautos; i++)
            //        {
            //            //Form1.dataGridView1.Rows.Add(_Autos[i].Marca);
            //        }
            //        break;

            //    case "moto":
            //        for (int i = 0; i < _nummotos; i++)
            //        {
            //            //Form1.dataGridView1.Rows.Add(_Motos[i].Marca);
            //        }
            //        break;

            //    case "camion":
            //        for (int i = 0; i < _numcamiones; i++)
            //        {
            //            //Form1.dataGridView1.Rows.Add(_Camiones[i].Marca);
            //        }
            //        break;
            //}
            return _Autos;
        }
    }
}
