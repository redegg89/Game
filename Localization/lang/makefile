all:
	dotnet build
	@cp bin/Debug/net6.0/lang.dll .
	@rm -r bin
	@mv ./lang.dll ../../Assets/Plugins/Locale/lang.dll