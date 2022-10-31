# Trabalho ( Progama de Aposta) 
             

- Para que serve: o programa serve para permitir ao usuário fazer apostas referente a 13 jogos e permitir que o usuário obtenha as tabelas de aposta e resultado além dos seus acertos 
                  
- Como funciona: o programa solicita ao usuário a cada jogo sua aposta(vitória time um  ou empate ou vitória time dois) depois disso ele lê as apostas do usuário e atribui
1 a escolha do usuário e 0 as opções não escolhidas. No final o programa compara a aposta do usuário ao resultado pré-determinado e imprime as tabelas da aposta e do resultado respectivamente e os pontos referentes aos acertos. 

- Sobre as tabelas: as tabelas impressas no final do programa tem suas linhas relacionadas aos jogos(jogo1,jogo2...) e suas colunas relacionada aos acontecimentos e apostas(vitória 1 = vitória do primeiro time, empate = empate entre os times, vitória 2 = vitória do segundo time). Além disso, as tabelas são preenchidas com 0 e 1( sendo 1 referente aos locais marcado e 0 aos locais não marcados). 

- De que forma funciona:  1.O programa utiliza duas matrizes( uma predeterminada para a tabela do resultado e a outra vazia para que o usuário a partir de suas aposta atribua valores a ela), 
2.um vetor   chamado RecibimentodeApostas que arquiva as apostas do usuário(vitória time um  ou empate ou vitória time dois)  3. o primeiro conjunto de 
if/else ,que a partir da atribuição feita pelo usuário para o RecibimentodeApostas, atribua 1 para escolha do usuário e 0 para as outras opções(isso é feito a cada jogo). 4 o segundo conjunto de if/else que compara as escolhas do usuário ao resultado
predeterminado e calcula os pontos feitos pelo usuário  5. um conjunto de Console.WriteLine que permitem a existência da tabelas de aposta é resultado  6. um Console.WriteLine que mostra os pontos feitos pelo usuário

