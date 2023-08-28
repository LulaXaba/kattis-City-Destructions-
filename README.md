The problem statement for Kattis City Destructions is as follows:

You are a supervillain who wants to destroy a city with your powerful laser beam. The city consists of **n** buildings arranged in a row, numbered from **1** to **n**. Each building has a height **h<sub>i</sub>** and a durability **d<sub>i</sub>**. Your laser beam can destroy a building if its durability is less than or equal to the height of the building to its left. You can also choose to skip some buildings and not destroy them.

Your goal is to destroy as many buildings as possible with your laser beam, while minimizing the total height of the remaining buildings. You want to leave the city in ruins, not in rubble.

You are given the heights and durabilities of the buildings in the city. Find the optimal sequence of buildings to destroy with your laser beam, and the total height of the remaining buildings.

The first line of input contains an integer **n** (**1 ≤ n ≤ 10<sup>5</sup>**), the number of buildings in the city. The next line contains **n** integers **h<sub>1</sub>, h<sub>2</sub>, ..., h<sub>n</sub>** (**1 ≤ h<sub>i</sub> ≤ 10<sup>9</sup>**), the heights of the buildings. The last line contains **n** integers **d<sub>1</sub>, d<sub>2</sub>, ..., d<sub>n</sub>** (**1 ≤ d<sub>i</sub> ≤ 10<sup>9</sup>**), the durabilities of the buildings.

Output two lines. The first line should contain an integer **k**, the number of buildings you will destroy with your laser beam. The second line should contain **k** integers, the indices of the buildings you will destroy, in increasing order. If there are multiple optimal solutions, output any one of them.


