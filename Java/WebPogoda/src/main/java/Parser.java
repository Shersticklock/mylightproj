import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;

import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.Iterator;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Parser {
    //метод получения содержимого страницы по url
    private static Document getPage(String url) throws IOException {
        Document page = Jsoup.parse(new URL(url), 3000);
        return page;
    }
    // Получение элемента
    private static Element getElement(Document doc){
        Element element = doc.select("table[class=wt]").first();
        return element;
    }
    //Получение даты  из строки с помощью регулярного выражения
    private static String getDateFromString(String p) throws Exception {
        Pattern pattern = Pattern.compile("\\d{2}\\.\\d{2}");
        Matcher matcher = pattern.matcher(p);
        if(matcher.find())
            return matcher.group();
        throw new Exception("Can't extract date from string");
    }
    //Находим кол-во строк для первого дня
    private static int index(Element tab) {
        Elements ind = tab.select("tr");
        int i = -1;
        for(Element l:ind) {
            if (l.hasAttr("class")==true && i!=-1)
                break;
            else
                i++;

        }
    return i;
    }
    //Получение и печать значений для каждого дня
    private static void valuesLine(Elements val, int ind,int indfe){

        if(ind==0){
            for(int i=0; i < indfe; i++) {
                Element vale = val.get(ind+i);
                System.out.println(vale.text());
//                for(Element td : vale.select("td")) {
//                    System.out.print(td.text()+"   ");
//                }
            }
        }
        else
            for(int i=0; i < 4; i++) {
                Element vale = val.get(ind+i);
                System.out.println(vale.text());
//                for(Element td : vale.select("td")) {
//                    System.out.print(td.text()+"   ");
//                }
            }

    }
    //Вывод информации на консоль
    public static void printWth(String url) throws Exception {
        Document page = getPage(url);
        int i = 0;
        Element tableW = getElement(page);
        Elements names = tableW.select("tr[class=wth]");
        Elements values = tableW.select("tr[valign=top]");
        for (Element name : names) {
            String dateStr = name.select("th[id=dt]").text();
            String date = getDateFromString(dateStr.toString());
            System.out.println(date + "     Пог.явления          t°C  Давл. Вл. Ветер");
            valuesLine(values, i, index(tableW));
            System.out.println();
            if (i == 0)
                i += index(tableW);
            else
                i += 4;
        }
    }
    public static void main(String[] args) throws Exception {
        String URL = "http://www.pogoda.msk.ru";
        printWth(URL);
    }
}
