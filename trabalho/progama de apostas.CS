using System;
class HelloWorld {
  static void Main() {
 int[,] n = new int [13,3]{{1,0,0},{0,1,0},{0,0,1},{1,0,0},{0,1,0},{0,0,1},{1,0,0},{0,1,0},{0,0,1},{1,0,0},{0,1,0},{0,0,1},{1,0,0}};
   
    int pontos = 0;
   
     int[,] m = new int [13,3];
     string[] RecibimentodeApostas =  new string[13] ;
    Console.WriteLine("Bem vido ao progama de apostas");
      Console.WriteLine(" ");
      Console.WriteLine("para apostar nos jogos digite : vitoria time um    ou    empate    ou     vitoria time dois");
       Console.WriteLine("obs: o progama vai computar a aposta se houver erro de digitacao ");
     Console.WriteLine(" ");
      Console.WriteLine("No final do progama sera revelado duas tabelas que demontram respctivamente sua aposta e o resultado");
       
       
     Console.WriteLine("digite sua aposta para o jogo 1:");
    
     RecibimentodeApostas [0]= Console.ReadLine(); 
     if (RecibimentodeApostas [0]== "vitoria time um"){ 
       
        m[0,0] = 1;
          m[0,1] = 0;
          m[0,2] = 0;
     
         
     }else if (RecibimentodeApostas  [0]=="empate"){
        m[0,0] = 0;
          m[0,1] = 1;
          m[0,2] = 0;
     
         
     } else if (RecibimentodeApostas  [0] == "vitoria time dois"){ 
       
        m[0,0] = 0;
          m[0,1] = 0;
          m[0,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
            
            Console.WriteLine("digite sua aposta para o jogo 2:");
         RecibimentodeApostas  [1] = Console.ReadLine(); 
     if (RecibimentodeApostas  [1]  == "vitoria time um"){ 
       
        m[1,0] = 1;
          m[1,1] = 0;
          m[1,2] = 0;
     
         
     }else if (RecibimentodeApostas  [1] =="empate"){
        m[1,0] = 0;
          m[1,1] = 1;
          m[1,2] = 0;
     
         
     } else if (RecibimentodeApostas  [1]  == "vitoria time dois"){ 
       
        m[1,0] = 0;
          m[1,1] = 0;
          m[1,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
      
       Console.WriteLine("digite sua aposta para o jogo 3:");
        RecibimentodeApostas  [2]  = Console.ReadLine(); 
     if (RecibimentodeApostas  [2]  == "vitoria time um"){ 
       
        m[2,0] = 1;
          m[2,1] = 0;
          m[2,2] = 0;
     
         
     }else if (RecibimentodeApostas  [2] =="empate"){
        m[2,0] = 0;
          m[2,1] = 1;
          m[2,2] = 0;
     
         
     } else if (RecibimentodeApostas  [2]  == "vitoria time dois"){ 
       
        m[2,0] = 0;
          m[2,1] = 0;
          m[2,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
      Console.WriteLine("digite sua aposta para o jogo 4:");      
       RecibimentodeApostas  [3]  = Console.ReadLine();                                                                  
     if (RecibimentodeApostas  [3]  == "vitoria time um"){ 
       
        m[3,0] = 1;
          m[3,1] = 0;
          m[3,2] = 0;
     
         
     }else if (RecibimentodeApostas  [3] =="empate"){
        m[3,0] = 0;
          m[3,1] = 1;
          m[3,2] = 0;
     
         
     } else if (RecibimentodeApostas  [3]  == "vitoria time dois"){ 
       
        m[3,0] = 0;
          m[3,1] = 0;
          m[3,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
            
            Console.WriteLine("digite sua aposta para o jogo 5:");
   RecibimentodeApostas  [4]  = Console.ReadLine(); 
     if (RecibimentodeApostas [4]  == "vitoria time um"){ 
       
        m[4,0] = 1;
          m[4,1] = 0;
          m[4,2] = 0;
     
         
     }else if (RecibimentodeApostas  [4] == "empate"){
        m[4,0] = 0;
          m[4,1] = 1;
          m[4,2] = 0;
     
         
     } else if (RecibimentodeApostas  [4]  == "vitoria time dois"){ 
       
        m[4,0] = 0;
          m[4,1] = 0;
          m[4,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");        
    
      Console.WriteLine("digite sua aposta para o jogo 6:");
    RecibimentodeApostas  [5]  = Console.ReadLine(); 
     if (RecibimentodeApostas  [5]  == "vitoria time um"){ 
       
        m[5,0] = 1;
          m[5,1] = 0;
          m[5,2] = 0;
     
         
     }else if (RecibimentodeApostas  [5] =="empate"){
        m[5,0] = 0;
          m[5,1] = 1;
          m[2,2] = 0;
     
         
     } else if (RecibimentodeApostas  [5]  == "vitoria time dois"){ 
       
        m[5,0] = 0;
          m[5,1] = 0;
          m[5,2] = 1;
       } else 
            Console.WriteLine("houvi algum erro renicie o progama");
    
    
    
    Console.WriteLine("digite sua aposta para o jogo 7:");
     
RecibimentodeApostas  [6]  = Console.ReadLine();                                                                  
     if (RecibimentodeApostas  [6] == "vitoria time um"){ 
       
        m[6,0] = 1;
          m[6,1] = 0;
          m[6,2] = 0;
     
         
     }else if (RecibimentodeApostas  [6] =="empate"){
        m[6,0] = 0;
          m[6,1] = 1;
          m[6,2] = 0;
     
         
     } else if (RecibimentodeApostas  [6]  == "vitoria time dois"){ 
       
        m[6,0] = 0;
          m[6,1] = 0;
          m[6,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
            
            Console.WriteLine("digite sua aposta para o jogo 8:");
    RecibimentodeApostas  [7]  = Console.ReadLine(); 
     if (RecibimentodeApostas  [7]  == "vitoria time um"){ 
       
        m[7,0] = 1;
          m[7,1] = 0;
          m[7,2] = 0;
     
         
     }else if (RecibimentodeApostas  [7] =="empate"){
        m[7,0] = 0;
          m[7,1] = 1;
          m[7,2] = 0;
     
         
     } else if (RecibimentodeApostas  [7]  == "vitoria time dois"){ 
       
        m[7,0] = 0;
          m[7,1] = 0;
          m[7,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
      
       Console.WriteLine("digite sua aposta para o jogo 9:");
  RecibimentodeApostas  [8]  = Console.ReadLine(); 
     if (RecibimentodeApostas  [8]  == "vitoria time um"){ 
       
        m[8,0] = 1;
          m[8,1] = 0;
          m[8,2] = 0;
     
         
     }else if (RecibimentodeApostas  [8] =="empate"){
        m[8,0] = 0;
          m[8,1] = 1;
          m[8,2] = 0;
     
         
     } else if (RecibimentodeApostas  [8]  == "vitoria time dois"){ 
       
        m[8,0] = 0;
          m[8,1] = 0;
          m[8,2] = 1;
       } else
            Console.WriteLine("houvi algum erro renicie o progama");
    Console.WriteLine("digite sua aposta para o jogo 10:");
     
RecibimentodeApostas  [9] = Console.ReadLine();                                                                  
     if (RecibimentodeApostas  [9]  == "vitoria time um"){ 
       
        m[9,0] = 1;
          m[9,1] = 0;
          m[9,2] = 0;
     
         
     }else if (RecibimentodeApostas  [9] =="empate"){
        m[9,0] = 0;
          m[9,1] = 1;
          m[9,2] = 0;
     
         
     } else if (RecibimentodeApostas  [9]  == "vitoria time dois"){ 
       
        m[9,0] = 0;
          m[9,1] = 0;
          m[9,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
            
            Console.WriteLine("digite sua aposta para o jogo 11:");
    RecibimentodeApostas  [10] = Console.ReadLine(); 
     if (RecibimentodeApostas  [10]  == "vitoria time um"){ 
       
        m[10,0] = 1;
          m[10,1] = 0;
          m[10,2] = 0;
     
         
     }else if (RecibimentodeApostas  [10] =="empate"){
        m[10,0] = 0;
          m[10,1] = 1;
          m[10,2] = 0;
     
         
     } else if (RecibimentodeApostas  [10]  == "vitoria time dois"){ 
       
        m[10,0] = 0;
          m[10,1] = 0;
          m[10,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
      
       Console.WriteLine("digite sua aposta para o jogo 12:");
     RecibimentodeApostas  [11]  = Console.ReadLine(); 
     if (RecibimentodeApostas  [11]  == "vitoria time um"){ 
       
        m[11,0] = 1;
          m[11,1] = 0;
          m[11,2] = 0;
     
         
     }else if (RecibimentodeApostas  [11] =="empate"){
        m[11,0] = 0;
          m[11,1] = 1;
          m[11,2] = 0;
     
         
     } else if (RecibimentodeApostas  [11]  == "vitoria time dois"){ 
       
        m[11,0] = 0;
          m[11,1] = 0;
          m[11,2] = 1;
       } else
            Console.WriteLine("houvi algum erro renicie o progama");


     Console.WriteLine("digite sua aposta para o jogo 13:");
    
     RecibimentodeApostas [12]= Console.ReadLine(); 
     if (RecibimentodeApostas [12]== "vitoria time um"){ 
       
        m[12,0] = 1;
          m[12,1] = 0;
          m[12,2] = 0;
     
         
     }else if (RecibimentodeApostas  [12]=="empate"){
        m[12,0] = 0;
          m[12,1] = 1;
          m[0,2] = 0;
     
         
     } else if (RecibimentodeApostas  [12] == "vitoria time dois"){ 
       
        m[12,0] = 0;
          m[12,1] = 0;
          m[12,2] = 1;
     
     } else 
            Console.WriteLine("houvi algum erro renicie o progama");
    
      
      if (m[0,0] == n[0,0]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" "); 
      
      if (m[1,1] == n[1,1]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" ");
        

         if (m[2,2] == n[2,2]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" ");
      
         
         if (m[3,0] == n[3,0]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" "); 
      
      if (m[4,1] == n[4,1]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" ");
        

         if (m[5,2] == n[5,2]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" ");
        
         
            if (m[6,0] == n[6,0]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" "); 
      
      if (m[7,1] == n[7,1]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" ");
        

         if (m[8,2] == n[8,2]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" ");
       
         
         if (m[9,0] == n[9,0]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" "); 
      
      if (m[10,1] == n[10,1]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" ");
        

         if (m[11,2] == n[11,2]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" ");
         Console.WriteLine("sua aposta:");
    
      if (m[12,0] == n[12,0]){ 
          pontos = pontos + 1;
      }else Console.WriteLine(" "); 

    Console.WriteLine(""); Console.WriteLine("      vitoria1  empate  vitoria2 ") ;  
  Console.WriteLine("jogo1:" + "    "+ m[0,0]+ "    " + "   " + m[0,1] + "   " +  "   " + m[0,2]);
  Console.WriteLine("jogo2:" + "    "+ m[1,0]+ "    " + "   " + m[1,1] + "   " +  "   " + m[1,2]);
 Console.WriteLine("jogo3:" + "    "+ m[2,0]+ "    " + "   " + m[2,1] + "   " +  "   " + m[2,2]);     
    Console.WriteLine("jogo4:" + "    "+ m[3,0]+ "    " + "   " + m[3,1] + "   " +  "   " + m[3,2]);
 Console.WriteLine("jogo5:" + "    "+ m[4,0]+ "    " + "   " + m[4,1] + "   " +  "   " + m[4,2]);
  Console.WriteLine("jogo6:" + "    "+ m[5,0]+ "    " + "   " + m[5,1] + "   " +  "   " + m[5,2]);   
Console.WriteLine("jogo7:" + "    "+ m[6,0]+ "    " + "   " + m[6,1] + "   " +  "   " + m[6,2]);
 Console.WriteLine("jogo8:" + "    "+ m[7,0]+ "    " + "   " + m[7,1] + "   " +  "   " + m[7,2]);
    Console.WriteLine("jogo9:" + "    "+ m[8,0]+ "    " + "   " + m[8,1] + "   " +  "   " + m[8,2]); 
    Console.WriteLine("jogo10:" + "   "+ m[9,0]+ "    " + "   " + m[9,1] + "   " +  "   " + m[9,2]);
 Console.WriteLine("jogo11:" + "   "+ m[10,0]+ "    " + "   " + m[10,1] + "   " +  "   " + m[10,2]);
    Console.WriteLine("jogo12:" + "   "+ m[11,0]+ "    " + "   " + m[11,1] + "   " +  "   " + m[8,2]);  
Console.WriteLine("jogo13:" + "   "+ m[12,0]+ "    " + "   " + m[12,1] + "   " +  "   " + m[12,2]);     
        
        Console.WriteLine(" ");
        Console.WriteLine("Resultado dos jogos:");
       
    
    Console.WriteLine(""); Console.WriteLine("      vitoria1  empate  vitoria2 ") ;  
 
  Console.WriteLine("jogo1:" + "    "+ n[0,0]+ "    " + "   " + n[0,1] + "   " +  "   " + n[0,2]);
 
  Console.WriteLine("jogo2:" + "    "+ n[1,0]+ "    " + "   " + n[1,1] + "   " +  "   " + n[1,2]);
    
 Console.WriteLine("jogo2:" + "    "+ n[2,0]+ "    " + "   " + n[2,1] + "   " +  "   " + n[2,2]);  
 
 Console.WriteLine("jogo4:" + "    "+ n[3,0]+ "    " + "   " + n[3,1] + "   " +  "   " + n[3,2]);
 
  Console.WriteLine("jogo5:" + "    "+ n[4,0]+ "    " + "   " + n[4,1] + "   " +  "   " + n[4,2]);
    
 Console.WriteLine("jogo6:" + "    "+ n[5,0]+ "    " + "   " + n[5,1] + "   " +  "   " + n[5,2]);   
 
Console.WriteLine("jogo7:" + "    "+ n[6,0]+ "    " + "   " + n[6,1] + "   " +  "   " + n[6,2]);
 
  Console.WriteLine("jogo8:" + "    "+ n[7,0]+ "    " + "   " + n[7,1] + "   " +  "   " + n[7,2]);
    
 Console.WriteLine("jogo9:" + "    "+ n[8,0]+ "    " + "   " + n[8,1] + "   " +  "   " + n[8,2]);       
  Console.WriteLine("jogo10:" + "   "+n[9,0]+ "    " + "   " + n[9,1] + "   " +  "   " + m[9,2]);
 Console.WriteLine("jogo11:" + "   "+n[10,0]+ "    " + "   " +n[10,1] + "   " +  "   " +m[10,2]);
    Console.WriteLine("jogo12:" + "   "+n[11,0]+ "    " + "   " +n[11,1] + "   " +  "   "+ n[8,2]); 
 Console.WriteLine("jogo13" + "    "+ n[12,0]+ "    " + "   " + n[12,1] + "   " +  "   " + n[12,2]);               
          
          Console.WriteLine(" ");
          
          
          
        
          Console.WriteLine(" ");
       
        Console.WriteLine(" Quantidade de pontos feitos = " + pontos);
  }
}
