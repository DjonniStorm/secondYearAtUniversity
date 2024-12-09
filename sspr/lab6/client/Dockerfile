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

# Открываем порт 80
EXPOSE 80

# Запускаем приложение с помощью npm
CMD ["node", "index.js"]