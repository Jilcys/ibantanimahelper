Basic NuGet package for finding bank name from TR Ibans </br>
<a>https://www.nuget.org/packages/ibantanimahelper/</a></br>


Simple usage: </br>
using ibantanimahelper; </br>

var x = new ibantanimahelper.findIban(); </br>
Console.WriteLine(x.IBANBUL("TR83 0020 3000 0000 0000 0000 01")); </br>
