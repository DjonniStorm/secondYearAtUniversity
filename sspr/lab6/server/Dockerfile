# Используем официальный образ Node.js
FROM node:alpine

# Устанавливаем рабочую директорию
WORKDIR /usr/src/app

# Копируем package.json и package-lock.json
COPY package*.json ./

# Устанавливаем зависимости
RUN npm install

# Копируем остальные файлы приложения
COPY . .

# Открываем порт 3000
EXPOSE 3000

# Запускаем приложение с помощью npm
CMD ["npm", "run", "start"]