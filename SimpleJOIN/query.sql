SELECT 
      people.name, people.id, COUNT(toys) AS toy_count
FROM 
      people 
JOIN 
      toys ON toys.people_id = people.id
GROUP BY
      people.id