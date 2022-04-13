import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class Youtube{

    public static void main(String[] args) throws InterruptedException {
        int n= 10;
        String url= "https://www.youtube.com/";

        System.setProperty("webdriver.chrome.driver", "D:/OneDrive/Documents/chromedriver.exe");
        WebDriver d = new ChromeDriver();
       d.get(url);
       Thread.sleep(5);
       WebElement signin= d.findElement(By.xpath("//*[@id=\"text\"]"));
       signin.sendKeys("saitejabalusu3");

       WebElement pass= d.findElement(By.xpath("//*[@id=\"password\"]/div[1]/div/div[1]/input"));
       pass.sendKeys("YOURPASSWORD");
        for (int i = 1; i <=n; i++) {
            //driver.FindElement(By.ClassName("dropdown-trigger.style-scope.ytd-menu-renderer")).Click();
            try {
                WebElement a = d.findElement(By.xpath("/html/body/ytd-app/div/ytd-page-manager/ytd-browse/ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/div[5]/ytd-rich-item-renderer[1]/div/ytd-rich-grid-media/div[" + i + "]/div/div[2]/ytd-menu-renderer/yt-icon-button/button/yt-icon"));
                        a.click();
            } catch (WebElement b = d.findElement(By.xpath("/html/body/ytd-app/div/ytd-page-manager/ytd-browse/ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/div[5]/ytd-rich-item-renderer[" + i + "]/div/ytd-rich-grid-media/div[1]/div/div[2]/ytd-menu-renderer/yt-icon-button/button/yt-icon"));
                    b.click();


            try {
                WebElement r = d.findElement(By.xpath("/html/body/ytd-app/ytd-popup-container/iron-dropdown/div/ytd-menu-popup-renderer/paper-listbox/ytd-menu-service-item-renderer/paper-item"))
                        r.click();
                n = n + 1;
                System.out.println("----------------------------------");
                System.out.println("number of video deleted  " + i);
            }
            catch (WebElement y= d.findElement(By.xpath("/html/body/ytd-app/ytd-popup-container/iron-dropdown/div/ytd-menu-popup-renderer/paper-listbox/ytd-menu-service-item-renderer/paper-item")).Click();

                System.out.println("number of video deleted  \" + i");
        }


    }
}

