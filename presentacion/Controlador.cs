using System;
using System.Collections.Generic;

class Controlador
{
    private Sistema _sistema;
    private Vista _vista;

    Dictionary<string, Action> _casosDeUso;

    public Controlador(Sistema sistema, Vista vista)
    {
        _sistema = sistema;
        _vista = vista;
        _casosDeUso = new Dictionary<string, Action>{
            {"Casos de Uso 1", CasoDeIso1},
            {"Casos de Uso 2", CasoDeUso2}
        };
    }

    public void Run(){

    }
    void CasoDeIso1()
    {

    }
    void CasoDeUso2()
    {

    }
}