/*-----------------------------------------------------------------------------
// Runtime: 730ms
// Memory Usage: 0 B
// Link: https://leetcode.com/submissions/detail/821562917/
//-----------------------------------------------------------------------------*/
SELECT user_id,
       CONCAT(UPPER(LEFT(name, 1)), LOWER(RIGHT(name, LENGTH(name) - 1))) AS name
FROM Users
ORDER BY user_id
