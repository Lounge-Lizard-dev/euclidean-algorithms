<script>

// working of extended
// Euclidean Algorithm

// Javascript function for
// extended Euclidean
// Algorithm
function gcdExtended(a, b,	
					x, y)
{
	// Base Case
	if (a == 0)
	{
		x = 0;
		y = 1;
		return b;
	}

	// To store results
	// of recursive call
	let gcd = gcdExtended(b % a,
					a, x, y);

	// Update x and y using
	// results of recursive
	// call
	x = y - (b / a) * x;
	y = x;

	return gcd;
}

// Driver Code
let x = 0;
let y = 0;
let a = 35;
let b = 15;
let g = gcdExtended(a, b, x, y);
document.write("gcd(" + a);
document.write(", " + b + ")");
document.write(" = " + g);
		
</script>
