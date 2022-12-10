using System;

namespace Program{

    public class AireAcondicionado{
    
    private string[] Marcas = {"SAMGUNG","HAIER","NEDOCA"};
    private string[] Estatus = {"Stand-By","Encendido"};
    private string rEstatus = "Stand-By";
    private string Mensaje = "\n\tEl aire esta apagado por lo que no esta disponible esta opcion.";
    private double[] VelocidadFan = {0.00,1.00,2.00,3.00,4.00};
    private double VFan = 0.00;
    private double Temperatura = 0.00;
    private string MarcaSeleccionada = "";


    public string Encender(){
        this.VFan = this.VelocidadFan[1];
        this.Temperatura = 17.00;
        return Estatus[1];
    }

    public string Apagar(){
        this.VFan = this.VelocidadFan[0];
        this.Temperatura = 0.00;
        return Estatus[0];

    }

    public void SubirTemp(){
        if (this.rEstatus == this.Estatus[1]){
            if(this.Temperatura < 30.00) this.Temperatura++;
        }
        else{
            Console.WriteLine(this.Mensaje);
            Console.ReadKey();
        }

    }

    public void BajarTemp(){
        if (this.rEstatus == this.Estatus[1]){
            if(this.Temperatura > 0.00) this.Temperatura--;
        }
        else{
            Console.WriteLine(this.Mensaje);
            Console.ReadKey();
        }

    }

    public void SubirVelocidad(){
        if (this.rEstatus == this.Estatus[1]){
            if(this.VFan < 4.00) this.VFan++;
        }
        else{
            Console.WriteLine(this.Mensaje);
            Console.ReadKey();
        }

    }

    public void BajarVelocidad(){
        if (this.rEstatus == this.Estatus[1]){
            if(this.VFan > 0.00) this.VFan--;
        }
        else{
            Console.WriteLine(this.Mensaje);
            Console.ReadKey();
        }


    }

    public void SeleccionMarca(){
        volver:
        Console.WriteLine("\n\t> Primer Parcial : Aire Acondicionado\n\n\tSeleccione la marca del aire: ");
        Console.WriteLine("\n\t1.Samsung\n\t2.Haier\n\t3.Nedoca");
        char opcion = Console.ReadKey(true).KeyChar;
        switch(opcion){
             case '1': this.MarcaSeleccionada = this.Marcas[0]; break;
             case '2': this.MarcaSeleccionada = this.Marcas[1]; break;
             case '3': this.MarcaSeleccionada = this.Marcas[2]; break;
             default: Console.WriteLine("\n\tSeleccione la opcion correcta.");
             Console.ReadKey();
             Console.Clear();
             goto volver;
        }

    }

    public void Funciones(){
        Console.WriteLine("\n\t> QUE DESEA REALIZAR?");
        Console.WriteLine("\n\t1.Subir temperatura\n\t2.Bajar temperatura\n\t3.Subir Velocidad\n\t4.Bajar Velocidad\n\t5.Apagar\n\t6.Encender");
        char opcion = Console.ReadKey(true).KeyChar;
        switch(opcion){
             case '1': SubirTemp(); break;
             case '2': BajarTemp(); break;
             case '3': SubirVelocidad(); break;
             case '4': BajarVelocidad(); break;
             case '5': this.rEstatus =  Apagar(); break;
             case '6': this.rEstatus = Encender(); break;
             default: Console.WriteLine("\n\tSeleccione la opcion correcta."); 
             Console.ReadKey(); 
             Console.Clear();
             break;  
             
    }

}

    public void DatosAire(){
        Console.Clear();
        Console.WriteLine("\n\n\t> DETALLES DEL AIRE");
        Console.WriteLine("\n\tMarca: " + this.MarcaSeleccionada);
        Console.WriteLine("\tEstatus: " + this.rEstatus);
        Console.WriteLine("\tTemperatura: " + this.Temperatura + " grados");
        Console.WriteLine("\tVelocidad: " + this.VFan);
    }

  }
     public class TesterClass{

         public static void Main(){
            AireAcondicionado Objeto = new AireAcondicionado();
            Objeto.SeleccionMarca();
            inicio:
            Objeto.DatosAire();
            Objeto.Funciones();
            goto inicio;
        }
    }

}