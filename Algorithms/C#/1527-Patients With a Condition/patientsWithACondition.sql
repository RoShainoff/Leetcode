/*-----------------------------------------------------------------------------
// Runtime: 370ms
// Memory Usage: 0 B
// Link: https://leetcode.com/submissions/detail/821572611/
//-----------------------------------------------------------------------------*/
SELECT * 
FROM patients 
WHERE conditions 
REGEXP '\\bDIAB1'
