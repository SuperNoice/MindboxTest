/* 
	В задании ничего не было сказано про структуру таблиц, поэтому я предположил, что таблицы будут следующего вида:
	Goods: id, name
	Categories: id, name
	good_category_cross: id, id_good, id_category

	
	SQL запрос выборки всех пар "Имя продукта – Имя категории":

	SELECT
		g.name,
		gn.name
	FROM
		Goods AS g
	LEFT JOIN (
		SELECT
			gcc.id_good,
			c.name
		FROM
			good_category_cross AS gcc
		JOIN Categories AS c ON
			c.id = gcc.id_category) AS gn
	ON
		g.id = gn.id_good;
*/
