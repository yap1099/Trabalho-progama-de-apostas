using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] tabeladearesultado = new int [13,3]{{1,0,0},{0,1,0},{0,0,1},{1,0,0},{0,1,0},{0,0,1},{1,0,0},{0,1,0},{0,0,1},{1,0,0},{0,1,0},{0,0,1},{1,0,0}};
int[,] tabeladeaposta = new int [13,3]; 
int aposta;
int pontos = 0 ;
int linha=0, coluna=0;

// lê as apostas do usuario por um looping e deziguina, na matriz da aposta, os locais de marcação com 1 e os locais sem marcação com 0 atraves de um if/else
Console.WriteLine("Ola usuario bem vindo ao progama de apostas");
Console.WriteLine("Para apostar digite: 1(caso voce acredite na vitoria do time um) 0(caso voce acredite no empate) 2(caso voce acredite na vitoria do time dois)");
for( linha = 0; linha < 13; linha++){
        Console.WriteLine($"Jogo {linha+1} Digite sua aposta:");
        aposta = int.Parse(Console.ReadLine());
 
        if(aposta == 1){
            tabeladeaposta[linha,0] = 1;
        }else if (aposta == 0){
            tabeladeaposta[linha,1] = 1; 
        }else if (aposta == 2){
           tabeladeaposta[linha,2] = 1;
        }else 
            Console.WriteLine("");
 } 
//  Compara a matriz da aposta com a matiz do resultado e caso as mesmas posições das matrizes seja igual a 1 o progama aumenta os pontos do usuario
for(linha = 0; linha < 13; linha++){ 
for(coluna = 0; coluna < 3; coluna++){  

if((tabeladearesultado[linha,coluna] ==1) && (tabeladeaposta[linha,coluna]==1)) {
pontos++; 
   } 
 } 
}  
   // escreve a matiz aposta
    Console.WriteLine("");
    Console.WriteLine("Aposta:");
   
    for(linha = 0; linha < 13; linha++){ 
for(coluna = 0; coluna < 3; coluna++){  
 if (coluna < 2) {
	    Console.Write (tabeladeaposta[linha,coluna]);
	  }else
	    Console.WriteLine (tabeladeaposta[linha,coluna]);  
	       

} 
} 
  // escreve a matriz rasultado
   Console.WriteLine("");
   Console.WriteLine("Resultado:");
   
for(linha = 0; linha < 13; linha++){
for(coluna = 0; coluna < 3; coluna++){
if (coluna < 2) {
	    Console.Write (tabeladearesultado[linha,coluna]);
	  }else
	    Console.WriteLine (tabeladearesultado[linha,coluna]); 
    } 
} 
 // escreve os pontos que o usuario fez
  Console.WriteLine(""); 
  Console.WriteLine("Pontos feitos :" + pontos);
} 
}
