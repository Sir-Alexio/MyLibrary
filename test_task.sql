create table products(
    product_id int ,
    name varchar(255),
    primary key(product_id)
    
);

create table categories(
    category_id int,
    name varchar(255),
    primary key(category_id)
    
);

create table productCategory(
    prod_id int,
    categ_id int,
    primary key(prod_id, categ_id),
    foreign key(prod_id) references products(product_id) on delete cascade,
    foreign key(categ_id) references categories(category_id) on delete cascade
);

insert into products VALUES(1, "milk");
insert into products VALUES(2, "chocolate");
insert into products VALUES(3, "meat");
insert into products VALUES(4, "bread");

insert into categories VALUES(1, "milk product");
insert into categories VALUES(2, "perishable");
insert into categories VALUES(3, "bakery");

insert into productCategory VALUES(1, 1);   
insert into productCategory VALUES(1, 2);
insert into productCategory VALUES(2, 1);
insert into productCategory VALUES(2, 2);
insert into productCategory VALUES(3, 2);
insert into productCategory VALUES(4, 2);
insert into productCategory VALUES(4, 3);


select products.name as product_name, categories.name as category_name
from productCategory
RIGHT join products
on productCategory.prod_id = products.product_id
inner join categories
on productCategory.categ_id = categories.category_id;