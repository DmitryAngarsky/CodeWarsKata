SELECT products.name AS product_name, EXTRACT(YEAR FROM sales.date)::INT AS year, 
  EXTRACT(MONTH FROM sales.date)::INT AS month, EXTRACT(DAY FROM sales.date)::INT AS day,
  price * count AS total
  FROM sales_details
  LEFT JOIN sales ON sales_details.sale_id = sales.id 
  CROSS JOIN products 
  ORDER BY product_name, year, month, day;