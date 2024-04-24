# MindboxLib

[![.NET Core Desktop](https://github.com/AleksandrKonst/MindboxLib/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/AleksandrKonst/MindboxLib/actions/workflows/dotnet-desktop.yml)

1. [**Вопрос №1.**](#01)
2. [**Вопрос №2.**](#02)

## 01. Вопрос №1.<a name="01"></a>
Разместите код на `Github` и приложите ссылку. Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения. Например, в комментариях в коде.
### Задание:
Напишите на `C#` библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

## Решение
Была создана библиотека с использованием рефлексии для анализа сборки. Создана абстрактная фабрика для классов реализующих `IFigure`.

Библиотека протестирована с использованием автоматических модульных тестов [GitHub Actions](https://github.com/AleksandrKonst/MindboxLib/actions) и `XUnit`.

## 02. Вопрос №1.<a name="02"></a>
В базе данных `MS SQL Server` есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

По возможности — положите ответ рядом с кодом из первого вопроса.

## Структура БД



## Запрос
Запрос под `PostgreSQL`.

```sql
SELECT p."name" || ' - ' || coalesce(c."name",'нет категории') as NameOfProduct
FROM products as p 
LEFT JOIN categoryproducts as cp ON p.id = cp.id_product  
LEFT JOIN category as c ON cp.id_category  = c.id;
```

Запрос под `MS SQL Server`.

```sql
SELECT p.[name] + ' - ' + ISNULL(c.[name],'нет категории') as NameOfProduct
FROM products as p 
LEFT JOIN categoryproducts as cp ON p.id = cp.id_product  
LEFT JOIN category as c ON cp.id_category  = c.id;
```

## Проверка

