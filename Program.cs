var timesSP = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo" };
var timesRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };
var timesBA = new HashSet<string>() { "Bahia", "Vitória", "Juazeiro" };
var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

if (!timesSP.Contains("Corinthians"))//verifico se o time existe, se sim, o código não adciona o clube de forma repetida. Se não existir, o código adciona o valor ao conjunto HashSet
{
    timesSP.Add("Corinthians");
    timesSP.Add("Santos");
}

//if (timesSP.IsSubsetOf(timesMundiais))//verifica se os conteudos de timesSP estão todos dentro do conjunto timesMundiais, se sim, retornara true, avisando que timesSP é um subconjunto de timesMundiais
//{
//    Console.WriteLine("timesSP é um subconjunto de timesMundiais\n");
//}

//if (timesMundiais.IsSupersetOf(timesSP))//verifica se os valores de timesMundiais estão dentro do conjunto timesSP, se sim, retornara true e exibira na tela que timesMundiais é um superconjunto de timesSP
//{
//    Console.WriteLine("timesMundiais é um superconjunto de timesSP\n");
//}

//if(timesRJ.Overlaps(timesMundiais))//verifica se pelo menos um valor do conjunto timesRJ se encontra no conjunto timesMundiais
//{
//    Console.WriteLine("Pelo menos um time do RJ tem título Mundial");
//}

//if(!timesSP.SetEquals(timesRJ))//verifica se os conjutos definidos possuem exatamente os mesmo elementos, se sim retorna true, se não retorna false
//{
//    Console.WriteLine("\nTimesSP e timesRJ não contém os mesmo elementos");
//}

//Console.WriteLine("\nJuntando os HashSet<T>: SP , RJ e BA");
//timesSP.UnionWith(timesRJ);//Adciono na coleção timesSP os valores da coleção times RJ
//timesSP.UnionWith(timesBA);//adciono na coleção timesSP os valores da coleção times BA, porém nesse caso, agora a coleção timesSP já contém tambem os valores de timesRJ

//ExibirColecao(timesSP);

//Console.WriteLine("\nJuntando os Times de SP, RJ e BA ordenados");
//var todosTimes = new SortedSet<string>(timesSP);
//ExibirColecao(todosTimes);

//timesSP.IntersectWith(timesMundiais);//verifica os valores de timesSP que estão na coleção timesMundiais
//ExibirColecao(timesSP);

//Console.WriteLine("\nDiferenca de dois HashSet<T> : timesMundiais e timesSP");
//timesMundiais.ExceptWith(timesSP);//verifica os resultados de timesMundiais que não se encontram na coleção timesSP, em resumo compara as 2 coleções e retorna os valores que eles não tem em comum
//ExibirColecao(timesMundiais);

Console.WriteLine("\nDiferenca de dois HashSet<T> : timesMundias e timesSP com SymmetricExceptWith");
timesMundiais.SymmetricExceptWith(timesSP);//retorna o valor de times que tem em uma tabela unica, mas não tem em comum entre as duas tabelas, ou seja, como corinthians está apenas em uma tabela(timesSP) e não está em times RJ, ele vai retornar corinthains, mas valores que as tabelas tem em comum como por exemplo São Paulo, não ira retornar
ExibirColecao(timesMundiais);

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine($"{item}");
    }
}