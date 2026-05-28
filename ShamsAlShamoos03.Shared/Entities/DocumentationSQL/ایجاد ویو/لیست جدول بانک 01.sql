SELECT  
    t.name AS TableName,
    t.create_date AS CreateDate,
    t.modify_date AS LastModifyDate,
    SUM(p.rows) AS RowCounts
FROM sys.tables t
JOIN sys.partitions p ON t.object_id = p.object_id
WHERE p.index_id IN (0,1)   -- 0 = heap, 1 = clustered index (برای شمردن رکوردها)
GROUP BY t.name, t.create_date, t.modify_date
ORDER BY t.modify_date DESC;
