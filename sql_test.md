Создал таблицу Продукты и Категори , В таблице сделал колонку idCategory , сделал FOREIGN KEY( idCategory )references Category(id),
И запрос
Select p.name as Products,
       c.name as Category
From Products p Left  join Category c on p.idCategory=c.id 