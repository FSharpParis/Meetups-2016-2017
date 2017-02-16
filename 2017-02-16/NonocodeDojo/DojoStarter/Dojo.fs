module Dojo

// Here is a proposed model
// You can remove it and use whatever you find more convenient!
type Color = | White | Black
type Cell = Color option
type Block = int
type Blocks = Block list

type Constraints = {
    Horizontal: Blocks list
    Vertical: Blocks list }

type Grid = Cell[,]

// Here you should write your dojo/exercise logic

let isThisReallyTrue x = true
