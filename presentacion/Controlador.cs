using System;
using System.Collections.Generic;
using System.Linq;
class Controlador
{
    private Sistema _sistema;
    private Vista _vista;

    Dictionary<string, Action> _casosDeUso;

    public Controlador(Sistema sistema, Vista vista)
    {
        this._sistema = sistema;
        this._vista = vista;
        this._casosDeUso = new Dictionary<string, Action>(){
                // Action = Func sin valor de retorno
                { "Caso de Uso 1", CasoDeUso1 },
                { "Caso de Uso 2", CasoDeUso2 },
                {"PruebasDeObtenerEntradaDeTipo", PruebasDeObtenerEntradaDeTipo },
                // Lambda
                { "Obtener la luna",() => vista.Display($"Caso de uso no implementado") },
            };
    }

    public void Run()
    {
        while (true)
        {
            try
            {  
                var key = _vista.TrySeleccionarOpcionDeListaEnumerada<string>(
                    "Titulo", _casosDeUso.Keys,
                    "Elige una opcion"
                );
                _casosDeUso[key].Invoke();
            }
            catch
            {
                _vista.Display("See you in space cowboy");
            }
        }
    }
    void CasoDeUso1()
    {
        _vista.Display("CAOS 1");
    }
    void CasoDeUso2()
    {
        _vista.Display("CAOS 2");
    }
    void PruebasDeObtenerEntradaDeTipo(){
         try
            {
                /*var s = _vista.TryObtenerEntradaDeTipo<string>("un string");
                var d = _vista.TryObtenerEntradaDeTipo<decimal>("un decimal");
                var f = _vista.TryObtenerEntradaDeTipo<float>("un float");
                var i = _vista.TryObtenerEntradaDeTipo<int>("un int");*/
                var i = _vista.TryObtenerEntradaDeTipo<int>("un int");
            var i2 = _vista.TryObtenerEntradaDeTipo<int>("un int2");
            var data = new DataModel
            {
                a = i,
                b = i2
            };
            var result = _sistema.SumaDataOno(data);
            _vista.Display($"El resultado es {result}");
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
    }
}