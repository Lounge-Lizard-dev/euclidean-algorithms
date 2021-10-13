<?php
// working of extended
// Euclidean Algorithm

// PHP function for
// extended Euclidean
// Algorithm
function gcdExtended($a, $b,	
					$x, $y)
{
	// Base Case
	if ($a == 0)
	{
		$x = 0;
		$y = 1;
		return $b;
	}

	// To store results
	// of recursive call
	$gcd = gcdExtended($b % $a,
					$a, $x, $y);

	// Update x and y using
	// results of recursive
	// call
	$x = $y - floor($b / $a) * $x;
	$y = $x;

	return $gcd;
}

// Driver Code
$x = 0;
$y = 0;
$a = 35; $b = 15;
$g = gcdExtended($a, $b, $x, $y);
echo "gcd(",$a;
echo ", " , $b, ")";
echo " = " , $g;

?>
