public static class Equipo{
    public static List<string> listaEquipos {get; private set;} = new List<string>(){"River", "Boca", "San Martín de Tucumán", "Nueva Chicago", "Depertivo Riestra", "Guillermo Brown", "Deportivo Maipú", "Villa Dalmine", "Chaco For Ever", "Justo José de Urquiza"};
    public static List<string> listaMedias {get; private set;}
    public static List<string> listaPantalones {get; private set;}
    public static List<string> listaRemeras {get; private set;}
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;}

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria cargar){
        if(EquiposIndumentaria.ContainsKey(EquipoSeleccionado)) return true;
        else return false;
    }

}