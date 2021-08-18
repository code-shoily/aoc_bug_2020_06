module Tests

open Xunit
open AoCBug202006.Data.Raw
open AoCBug202006.Program.Solution

[<Fact>]
let ``Test input has correct number of lines`` () =
    let input = input.Trim().Split "\n"
    Assert.Equal(Seq.length input, 2257)

[<Fact>]
let ``Test solution for 2020/06`` () =
    let expected = (6885, 3550)
    let actual = solve <| input.Trim().Split "\n"
    Assert.Equal(expected, actual)
