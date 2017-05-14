require 'fileutils'
require 'rubygems'

task :default => [:clean, :build]

desc "Cleans the project"
task :clean do
  directories_to_delete = [
      "./XamarinTestProject/XamarinTestProject.iOS/bin",
      "./XamarinTestProject/XamarinTestProject.iOS/obj",
      "./XamarinTestProject/XamarinTestProject.Droid/bin",
      "./XamarinTestProject/XamarinTestProject.Droid/obj",
      "./XamarinTestProject/XamarinTestProject/bin",
      "./XamarinTestProject/XamarinTestProject/obj"
  ]

  directories_to_delete.each { |x|
    rm_rf x
  }
end

desc "Compiles the Android and iOS projects."
task :build => [:build_android] do

end

task :build_android => [:clean] do
  `/Library/Frameworks/Mono.framework/Commands/xbuild /t:SignAndroidPackage /p:Configuration=Release ./XamarinTestProject/XamarinTestProject.Droid/XamarinTestProject.Droid.csproj`
end
