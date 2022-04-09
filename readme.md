# PdTool
A tool written in .NET to programmatically generate Pure Data patches. 

## TODO's
<ul>

<li>Add support for coloring objects</li>

</ul>

## Examples
This following code creates a patch containing a horizontal slider connected to a number box. The patch is then saved as 'patch.pd'.

```csharp
var main = new Patch(0, 0, 500, 500);

var hsl = new Hsl(200, 200);
var num = new Number(200, 300);

main.AddNode(hsl);
main.AddNode(num);

main.Connect(hsl, num);

main.Save("patch.pd");
```

#### Subpatch example:
The following example creates a subpatch that takes in a number, adds 1 to it, and outputs it

```csharp
var main    = new Patch(0, 0, 500, 500);

var numIn   = new Number(250, 100);
var numOut  = new Number(250, 300);
            
var sub     = new Patch("add-one", 250, 200, 500, 500);

var inlet   = new Obj("inlet", 250, 100);
var add     = new Obj("+ 1", 250, 150);
var outlet  = new Obj("outlet", 250, 200);

sub.AddNode(inlet);
sub.AddNode(add);
sub.AddNode(outlet);

sub.Connect(inlet, add);
sub.Connect(add, outlet);

main.AddNode(numIn);
main.AddNode(sub);
main.AddNode(numOut);

main.Connect(numIn, sub);
main.Connect(sub, numOut);

main.Save("patch.pd");

```

#### Connection example:
Connect osc~ to both inlets of dac~

```csharp
Patch main = new Patch(0, 0, 500, 500);

var osc = new Obj("osc~ 440", 250, 100);
var mul = new Obj("*~ 0.2", 250, 150);
var dac = new Obj("dac~", 250, 200);

main.AddNode(osc);
main.AddNode(mul);
main.AddNode(dac);

main.Connect(osc, mul); //Connect osc to left inlet of mul
main.Connect(mul, dac); //Connect mul to left inlet of dac

main.Connect(new ConnSrc(mul), new ConnSink(dac, 1)); //Connect mul to right inlet of dac

main.Save("patch.pd");
```
