
public class DicLearn{

public static void Dict(){
  char[] letras = {'A', 'B', 'A', 'C', 'B', 'A', 'D', 'E', 'A', 'B', 'C', 'E'};
  Dictionary<char, int> conteo = new Dictionary<char, int>();
  
  foreach (char letra in letras)
  {  
    if (!conteo.ContainsKey(letra)) ////aqui preguntamos si NO existe  en el diccionario "conteo"
    {
      conteo[letra] = 1 ; //aqui decimos que es el primer conteo de la letra

    }else //si ya existe entonces
    {
      conteo[letra]++;
      
      }//aqui ya se creó un diccionario con pares clave valor y vamos sumando el conteo del valor
   
   }
    foreach (var par in conteo)
    {
      
      Console.WriteLine($"{par.Key} =>{par.Value}");
      
    }

  }
    public static string Traductor(string palabra){
      var translator = new Dictionary<string,string>
      {
          ["Dog"] = "Perro",
          ["Cat"] = "Gato",
          ["Bird"] = "Pajaro",
          ["Alligator"] = "Cocodrilo",
          ["Cow"] = "Vaca"  
      };

      if (translator.ContainsKey(palabra))
      {
        return translator[palabra];
      }
      else
      {
        return "???";
      }

  }

 
}