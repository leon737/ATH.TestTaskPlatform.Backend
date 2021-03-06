﻿insert scope (id, active) values('16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA', 1)

insert [user](id, name, scopeid)
values 
('028da07e-6a0c-4768-a8ba-1e92dd85c3ca', N'Леонтий Ковалёв', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('f3424c95-4c2b-4df2-a127-36a677bbb79c', N'Геннадий Бобров', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('2f5e3da7-334b-490f-b334-50a81a248e1d', N'Захар Дроздов', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('87be9dbb-6766-483d-bbec-67d94a210c24', N'Кузьма Бобров', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('DA5E8C51-5AEE-4E94-BB4A-D008976B9166', N'Сергей Белоусов', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('27212DDF-912D-420B-AC7E-873E0478E359', N'Сева Ершов', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('168B02E4-2441-420F-8328-FB3BEA57E391', N'Снежана Гуляева', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('58B05A19-9C4C-4DD6-92F5-9CA2E25AE64B', N'Нина Чиркина', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('6ABF7A67-B530-4361-B365-B40F1FBE946B', N'Диана Боженова', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('25210E33-0DB7-4969-A458-0038E010AEB4', N'Мария Куликова', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('EA366414-0753-4862-9158-DE7B525D6A1F', N'Василина Петрова', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA')

insert task(id, name, description, workload, status, ExecutorId, scopeid)
values
('9C5D68A4-4A22-4A7E-AFCA-62147CA16CE5', 'Тестовая задача #1', 'Описание тестовой задачи #1', 8, 1, null, '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('199BEE24-A318-4769-923B-4D9FC3628C26', 'Тестовая задача #2', 'Описание тестовой задачи #2', 16, 2, '028da07e-6a0c-4768-a8ba-1e92dd85c3ca', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('14F902E7-E11C-449F-A0AF-93E4C8FC13D3', 'Тестовая задача #3', 'Описание тестовой задачи #3', 32, 3, '028da07e-6a0c-4768-a8ba-1e92dd85c3ca', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('EF68C1B1-E485-4718-B422-99BB5BA507F1', 'Тестовая задача #4', 'Описание тестовой задачи #4', 64, 1, '2f5e3da7-334b-490f-b334-50a81a248e1d', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('743EC9FC-596A-4FB4-AD39-E2D730BBD88F', 'Тестовая задача #5', 'Описание тестовой задачи #5', 128, 2, 'DA5E8C51-5AEE-4E94-BB4A-D008976B9166', '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA'),
('C37E7866-411C-475D-BE14-B18E4019FD17', 'Тестовая задача #6', 'Описание тестовой задачи #6', 256, 3, null, '16E7EDB5-860F-4DA7-8B91-AA7FE8F102BA')