/*-----------------------------------------------------------------------------
// Runtime: 548ms
// Memory Usage: 0 B
// Link: https://leetcode.com/submissions/detail/821566299/
//-----------------------------------------------------------------------------*/
SELECT sell_date, COUNT( DISTINCT product ) AS num_sold ,    
GROUP_CONCAT( DISTINCT product ORDER BY product separator ',' ) AS products  
FROM Activities 
GROUP BY sell_date 
ORDER BY sell_date; 
