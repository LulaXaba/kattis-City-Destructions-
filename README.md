Modan is playing a new action strategy game, where his goal is to destroy a city.

A city is made up of "N" buildings, where the 
-th building initially has health 
. At every move, Modan can choose a building to attack, dealing 
 damage to it. When a building’s health falls below or equal to 
, it is destroyed. When the 
-th building gets destroyed, it explodes and deals 
 damage to the adjacent buildings, i.e. the 
-th and 
-th buildings, if they exist.

Modan is really addicted to the game and wants to know the minimum number of moves he needs to destroy a city.

Input
The first line contains a single integer 
 giving the number of test cases. Each test case has three lines. On the first line, there are two integers 
 (
), the number of buildings, and 
 (
), the amount of damage Modan can do. On the second line, there are 
 integers, with the 
-th integer being 
 (
), the initial health of the 
-th building. On the third line, there are 
 integers, with the 
-th integer being 
 (
), the amount of explosion damage the 
-th building does.

Output
For each test case, output a single line containing the minimum number of moves needed to destroy the city.

Sample Input 1	Sample Output 1
2
1 10
33
54
3 10
43 10 59
69 69 69
4
1
