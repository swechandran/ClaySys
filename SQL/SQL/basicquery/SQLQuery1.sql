CREATE TABLE products(
product_id INT,
region VARCHAR(100),
sales INT);

INSERT INTO products(product_id,region,sales)
VALUES(1,'east',100),
      (2,'west',200),
	  (3,'north',300),
	  (4,'south',400);
SELECT * FROM products;
--pivot and unpivot
select * from(select * from products) as source
pivot(
sum(sales) for region in([North],[south],[west],[east]))
as pivot_table;
--unpivot
select *  from (
select * from(select * from products) as source
pivot(
sum(sales) for region in([North],[south],[west],[east]))
as pivot_table) as source
unpivot
(sales for region in ([North],[south],[west],[east])) as unpivotetable;

