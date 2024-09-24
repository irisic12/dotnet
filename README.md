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
Пользователь может просматривать список всех доступных билетов и маршрутов.

#### (CREATE) Создание записи
Пользователь может создать новый билет на рейс, указав:
- Пассажирские данные (ФИО, контактная информация).
- Выбранный маршрут.
- Дату и время рейса.

#### (READ) Просмотр деталей записи
Пользователь может просмотреть детали конкретного билета, включая:
- Информацию о маршруте.
- Информацию об автобусе (гос. номер, тип, марка, страна производителя).
- Данные водителя.

#### (UPDATE) Редактирование записи
Пользователь может редактировать информацию о своем билете, включая:
- Изменение маршрута.
- Изменение даты и времени рейса.

#### (DELETE) Удаление записи
Пользователь может удалить свой билет, если это возможно по правилам компании.

---

## Примечания
- Все действия должны быть защищены от несанкционированного доступа.
- Интерфейс должен быть интуитивно понятным и удобным для пользователя.

---

## Контакты
Если у вас есть вопросы или предложения, пожалуйста, свяжитесь с нами по электронной почте: support@buscompany.com

## Проектная база
![Модель автобусных перевозок]((https://github.com/irisic12/dotnet/blob/main/модель%20автобусных%20перевозок.pdf))
