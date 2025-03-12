# HashSet-e-SortedSet

Código para aprender e testar as funcionalidades das coleçoes genericas HashSet e SortedSet

Primeiro de tudo, por que usar essas coleções invés de listas normais ou genericas?

O motivo para usar uma dessas coleções acima é que elas podem trabalhar com mais de um valor por vez, por que recebem já na criação a interface IEnumerable<T>.

Desse jeito possui alguns métodos especiais para lidar com mais de um valor na coleção.

ExcepWith(IEnumerable<T>) (Remove todos os elementos na coleção especificada do objeto HashSet<T> atual)

UnionWith(IEnumerable<T>) (Adiciona mais uma coleção na sua coleção, mantendo os valores da sua coleção atual)

RemoveWhere(Predicate<T>) (Remove todos os elementos que correspondem às condições definidas pelo predicado especificado de uma coleção de HashSet<T>)

etc...
