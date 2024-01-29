database silme /api : dotnet ef database drop
database günclleme /api : dotnet ef database update
database /api : dotnet ef migration add 
sqlite> select * from Products p, Comments c where p.Id = c.ProductId ; 
┌────┬────────┬────────┬─────────────────────────────┬───────────────┬───────────┬─────────────┬───────────┬─────────────────────────────┐
│ Id │  Name  │ Price  │        AtCreatedDate        │   ImageURL    │ CommentId │    Text     │ ProductId │        AtCreatedDate        │
├────┼────────┼────────┼─────────────────────────────┼───────────────┼───────────┼─────────────┼───────────┼─────────────────────────────┤
│ 1  │ Laptop │ 1500.0 │ 2024-01-06 14:11:01.2909422 │ /images/1.jpg │ 1         │ Harika Ürün │ 1         │ 2024-01-06 14:11:01.2907242 │
│ 1  │ Laptop │ 1500.0 │ 2024-01-06 14:11:01.2909422 │ /images/1.jpg │ 2         │ Harika Ürün │ 1         │ 2024-01-06 14:11:01.2907253 │
│ 1  │ Laptop │ 1500.0 │ 2024-01-06 14:11:01.2909422 │ /images/1.jpg │ 3         │ Harika Ürün │ 1         │ 2024-01-06 14:11:01.2907254 │
└────┴────────┴────────┴─────────────────────────────┴───────────────┴───────────┴─────────────┴───────────┴─────────────────────────────┘