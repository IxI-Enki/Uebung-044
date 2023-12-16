<!--              READE -> VORLAGE Uebungen: Programmieren & Software Engineering              -->

# Uebung-044 --  [***Vocal Filter***](https://github.com/IxI-Enki/Uebung-044/blob/main)  

<!-- ---------------------------------------------|-------------------------------------------- -->
###### 📎[**Angabe**](https://github.com/IxI-Enki/Uebung-044/blob/main/work-directory/FilterVocals-1.pdf) *.pdf*
<sup><sub> 
---
</sub></sup>

<!-- ---------------------------------------------|-------------------------------------------- -->
## 📊 Lernziele:  
  - ↳ Strings 

<sup><sub> </sub></sup>
---

<!-- ---------------------------------------------|-------------------------------------------- -->
## 🧮 **Aufgabenstellung:**  
  - Das Programm extrahiert aus dem eingegebenen Text alle Vokale (Groß/Kleinschreibung ist egal).
  - Als Vokale sind nur a,e,i,o,u und A,E,I,O,U zu berücksichtigen.
  - Kommt ein Vokal mehrfach vor, ist nur das erste Vorkommen zu verwenden.

*Orientieren Sie sich bei der Ausgabe an der Musterausgabe!*

---
 
<!-- ---------------------------------------------|-------------------------------------------- -->
## 🔎 **Ausgabe** <sub>*Bsp.*</sub> 


   |            *Musterausgabe*   |  
   | :-----------------------------------------------------------------------------------------------------------------: |
   |  ![**Ausgabebeispiel 📎**](https://github.com/IxI-Enki/Uebung-044/assets/138018029/8d2c1b61-8c6f-48e0-9dd3-556209aa69e4) |

<sup><sub> </sub></sup>
---

   |        ❗ *Testbeispiele*   |  
   | :-----------------------------------------------------------------------------------------------------------------: |
   |  ![**Testbeispiele: 📎**](https://github.com/IxI-Enki/Uebung-044/assets/138018029/9f15a5b1-7d6d-47e8-8322-d5f3629cc36a) |

---

<!-- ---------------------------------------------|-------------------------------------------- -->


# *SPOILER* <sub><sup> → [*Lösung*](https://github.com/IxI-Enki/Uebung-044/blob/main/FilterVokals/FilterVokals/FilterVocals.cs) <sup></sub>:


### 🖥 **Ausgabe**: 
   |            *Meine Ausgabe*   
   |--------------------------------|
   |  ![**Ausgabe 📎**](https://github.com/IxI-Enki/Uebung-044/assets/138018029/865d4b1c-58d4-4d7f-aa8a-14031b1522d4) |

---

## 💾 `C#` - *Programm*:
 <details><summary>👉 ausklappen 👈 </summary>


 ```c#
namespace FilterVocals      //  
{                           //
  public class Program      //
  {                         //
    static void Main()      //
    {
      ///*----------------------- console_settings ------------------------*///
      const int cWidth = 53;                     //  console width
      const int cHeight = 30;                    //  & height
      Console.SetWindowSize(cWidth, cHeight);    //
      Console.OutputEncoding = Encoding.UTF8;    //  Unicode Symbols

      /*----------------------------- VARIABLES -----------------------------*/
      string userInput,                       //  
             vocalCache = "",
             vocalCacheOut = "";
      char[] vocalLower = new char[5];
      vocalLower = ['a', 'e', 'i', 'o', 'u'];
      char[] vocalUpper = new char[5];
      vocalUpper = ['A', 'E', 'I', 'O', 'U'];

      int index;
      bool empty;

      /*-------------------------------- HEAD -------------------------------*/
      Console.Clear();
      Console.Write("\n             Vokale aus Text extrahieren             " +
      /* cWidth: */ "\n=====================================================");

      Console.Write("\n Text: ");
      userInput = Console.ReadLine();

      empty = (userInput.Length > 0) ? true : false;
      if (empty)
      {
        for (index = 0; index < userInput.Length; index++)
        {
          for (int i = 0; i < 5; i++)
          {
            if (userInput[index] == vocalLower[i] || userInput[index] == vocalUpper[i])
            {
              vocalCache = vocalCache + userInput[index];
              vocalLower[i] = ' ';
              vocalUpper[i] = ' ';
            }
          }
        }
        int length = vocalCache.Length;
        for (index = 0; length > index; index++)
        {
          if (vocalCache[index] != ' ')
          {
            vocalCacheOut = vocalCacheOut + vocalCache[index];
          }
        }
      }
      else
      { Console.Write("\n"); }

      Console.Write($"\n Der Text \"{userInput}\" enthält {vocalCacheOut.Length} Vokale: {vocalCacheOut}");

      /*-------------------------------- END --------------------------------*/
      Console.Write("\n Zum beenden Eingabetaste drücken..");
      Console.ReadLine();    //  wait for [enter]
      Console.Clear();       //
    }
  }
}

```


</dertails>
