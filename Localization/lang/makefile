all:
	dotnet build
install:
	@cp bin/Debug/net6.0/lang.dll .
	@rm -r bin
	@rm -r obj
	@mv ./lang.dll ../../Assets/Plugins/Locale/lang.dll