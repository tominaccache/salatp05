public static class escape{

public static string[] incognitasSalas;
private static int estadoJuego=1;




public static void InicializarJuego()
{
    
    estadoJuego=1;
    incognitasSalas=new string[]{"chicle", "huevo", "14","y"};
}

public static int GetEstadoJuego(){

    return estadoJuego;
}

public static bool ResolverSala(int Sala, string Incognita){

    if (Sala!=estadoJuego || Incognita!=incognitasSalas[estadoJuego-1]){
        return false;
    }
    estadoJuego=estadoJuego+1;
    return true;
}
}