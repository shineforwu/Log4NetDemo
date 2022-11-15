# Log4Net Demo
This Demo has two projects: LogCommon , LogTest

## Third party DLL
Add log4net.dll with nuget in 2 porjects.

## LogTest
### xml for App.config
	<configSections>
		<section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
	</configSections>

	<log4net>
		<!--错误日志类-->
		<logger name="logerror">
			<!--日志类的名字-->
			<level value="ALL" />
			<!--定义记录的日志级别-->
			<appender-ref ref="ErrorAppender" />
			<!--记录到哪个介质中去-->
		</logger>
		<!--信息日志类-->
		<logger name="loginfo">
			<level value="ALL" />
			<appender-ref ref="InfoAppender" />
		</logger>
		<!--错误日志附加介质-->
		<appender name="ErrorAppender" type="log4net.Appender.RollingFileAppender">
			<!-- name属性指定其名称,type则是log4net.Appender命名空间的一个类的名称,意思是,指定使用哪种介质-->
			<param name="File" value="Logs\\LogError\\" />
			<!--日志输出到exe程序这个相对目录下-->
			<param name="AppendToFile" value="true" />
			<!--输出的日志不会覆盖以前的信息-->
			<param name="MaxSizeRollBackups" value="100" />
			<!--备份文件的个数-->
			<param name="MaxFileSize" value="10240" />
			<!--当个日志文件的最大大小-->
			<param name="StaticLogFileName" value="false" />
			<!--是否使用静态文件名-->
			<param name="DatePattern" value="yyyyMMdd&quot;.txt&quot;" />
			<!--日志文件名-->
			<param name="RollingStyle" value="Date" />
			<!--文件创建的方式，这里是以Date方式创建-->
			<!--错误日志布局-->
			<layout type="log4net.Layout.PatternLayout">
				<param name="ConversionPattern" value="%n异常时间：%d [%t]  %n异常级别：%-5p  %n异 常 类：%c [%x]  %n%m  %n " />
			</layout>
		</appender>
		<!--信息日志附加介质-->
		<appender name="InfoAppender" type="log4net.Appender.RollingFileAppender">
			<param name="File" value="Logs\\LogInfo\\" />
			<param name="AppendToFile" value="true" />
			<param name="MaxFileSize" value="10240" />
			<param name="MaxSizeRollBackups" value="100" />
			<param name="StaticLogFileName" value="false" />
			<param name="DatePattern" value="yyyyMMdd&quot;.txt&quot;" />
			<param name="RollingStyle" value="Date" />
			<!--信息日志布局-->
			<layout type="log4net.Layout.PatternLayout">
				<param name="ConversionPattern" value="[时间] %d [%t] [信息] %m%n" />
			</layout>
		</appender>
	</log4net>
	
### Code for exe
	log4net.Config.XmlConfigurator.Configure();