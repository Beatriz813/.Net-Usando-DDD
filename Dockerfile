FROM mysql
ENV MYSQL_USER=beatriz MYSQL_PASSWORD=xablau123 MYSQL_ROOT_PASSWORD=xablau123
RUN mysql
# RUN DROP DATABASE PetshopDB
EXPOSE 3306