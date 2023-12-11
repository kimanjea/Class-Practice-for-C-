using System;
using System.Net.WebSockets;
using System.Security.AccessControl;



class Program {

    static void Main(string [] arg) {

      var azharhistory = new Player("Azhar Kimanje", 19); // call the class

      Console.WriteLine($"{azharhistory.name} plays No. {azharhistory.position} for the stars"); // testing our function
    }

}

class Player{ //class object implementation
    public string name { get; set; }
    public int position { get; set; } 
    public int Muys{ get; set; }
   public Player(string names, int positions) { // constructor
    this.name = names;
    position = positions;
   }
 }