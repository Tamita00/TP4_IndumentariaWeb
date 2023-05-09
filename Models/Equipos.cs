public static class Equipos{
    public static List<string> listaEquipos {get; private set;} = new List<string>(){"River", "Boca", "San Martín de Tucumán", "Nueva Chicago", "Depertivo Riestra", "Guillermo Brown", "Deportivo Maipú", "Villa Dalmine", "Chaco For Ever", "Justo José de Urquiza"};
    public static List<string> listaMedias {get; private set;} = new List<string>(){"medias1.jpg", "medias2.jpg", "medias3.jpg", "medias4.jpg","medias5.jpg", "medias6.jpg", "medias7.jpg", "medias8.jpg", "medias9.jpg", "medias10.jpg"};
    public static List<string> listaPantalones {get; private set;} = new List<string>(){"short1.jpg", "short2.jpg", "short3.jpg", "short4.jpg","short5.jpg", "short6.jpg", "short7.jpg", "short8.jpg", "short9.jpg", "short10.jpg"};
    public static List<string> listaRemeras {get; private set;} = new List<string>(){"remera1.jpg", "remera2.jpg", "remera3.jpg", "remera4.jpg","remera5.jpg", "remera6.jpg", "remera7.jpg", "remera8.jpg", "remera9.jpg", "remera10.jpg"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria conjunto){
        if(!EquiposIndumentaria.ContainsKey(EquipoSeleccionado))
        {
            EquiposIndumentaria.Add(EquipoSeleccionado, conjunto);
            return true;
        } 
        else return false;
    }

}