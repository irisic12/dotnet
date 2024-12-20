# Сеть автобусных перевозок

## Описание
Данная модель данных отображает внутреннее устройство автобусных перевозок. Она включает информацию о филиалах компании, работниках, маршрутах и билетах.

---

### 1. Регистрация пользователя
Пользователь должен иметь возможность зарегистрироваться в системе, предоставив следующие данные:
- Имя
- Фамилия
- Электронная почта
- Пароль

#### Требования:
- Проверка уникальности электронной почты.
- Подтверждение регистрации через электронную почту.

---

### 2. Логин и логаут пользователя
Пользователь должен иметь возможность войти в систему и выйти из нее.

#### Требования:
- Логин:
  - Ввод электронной почты и пароля.
  - Проверка корректности введенных данных.
  
- Логаут:
  - Пользователь должен иметь возможность выйти из системы одним кликом.

---

### 3. Управление записями

#### (INDEX) Просмотр списка записей
- **Обычные пользователи** могут просматривать список всех доступных билетов и маршрутов.
- **Администраторы** могут просматривать список всех билетов, маршрутов и рейсов.

#### (CREATE) Создание записи
- **Обычные пользователи** могут создать новый билет на рейс, указав:
  - Пассажирские данные (ФИО, контактная информация).
  - Выбранный маршрут.
  - Дату и время рейса.
  
- **Администраторы** могут добавлять новые рейсы и маршруты.

#### (READ) Просмотр деталей записи
Пользователь может просмотреть детали конкретного билета, включая:
- Информацию о маршруте.
- Информацию об автобусе (гос. номер, тип, марка, страна производителя).
- Данные водителя.

#### (UPDATE) Редактирование записи
- **Обычные пользователи** могут редактировать информацию о своем билете, включая:
  - Изменение маршрута.
  - Изменение даты и времени рейса.
  
- **Администраторы** могут редактировать информацию о рейсах и маршрутах.

#### (DELETE) Удаление записи
- **Обычные пользователи** могут удалить свой билет, если это возможно по правилам компании.
  
- **Администраторы** могут удалять рейсы и маршруты.

---
## Роли пользователей
- **Обычный пользователь**: может просматривать доступные билеты и маршруты, создавать, редактировать и удалять свои билеты.
- **Администратор**: имеет все права обычного пользователя плюс возможность управлять маршрутами и рейсами (добавление, изменение, удаление).

---

## Примечания
- Все действия должны быть защищены от несанкционированного доступа.
- Интерфейс должен быть интуитивно понятным и удобным для пользователя.

---

## Контакты
Если у вас есть вопросы или предложения, пожалуйста, свяжитесь с нами по электронной почте: support@buscompany.com

## Проектная база
![Модель автобусных перевозок]([file:///C:/Users/79005/ириночка/база для дотнета/bus.jpg](https://github.com/irisic12/dotnet/blob/main/база%20для%20дотнета.pdf))
