package bdtest;
import java.sql.*;
import com.mysql.cj.jdbc.Driver;

public class Main {
    private static final String URL = "jdbc:mysql://localhost:3306/bdlite?useUnicode=true&useSSL=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC";
    private static final String USER = "root";
    private static final String PASSWORD = "root";
    public static void main(String[] args) {
        Connection connect;
        //Регистрируем драйвер
        try{
            Driver driver = new com.mysql.cj.jdbc.Driver();
            DriverManager.registerDriver(driver);
        } catch (SQLException e){
            System.err.println("Драйвер не зарегистрировался");
        }
        //Устанавливаем соединение с БД
        try {
            connect = DriverManager.getConnection(URL, USER, PASSWORD);
            if (!connect.isClosed())
                System.out.println("Соединение c БД установленно");
        //Работа с данными
            Statement st = connect.createStatement();
            st.execute("INSERT INTO bdlite.hedpe(hedPEAlbum, hedPESong, hedPEYear) VALUES ('OnlyInAmerika','Untitled',2004)");
        //Закрываем соединение с БД
            connect.close();
            if(connect.isClosed())
                System.out.println("Соединение с БД закрыто");
        } catch (SQLException e){
            System.err.println("Соединение не установлено");
        }
    }
}
