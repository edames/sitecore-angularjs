var gulp = require('gulp'),
	shell = require('gulp-shell');

gulp.task('build', ['restore'], shell.task([
    'echo "Building Sitecore AngularJS..."',
    'msbuild MusicStore.Web.csproj /p:Configuration=Debug'
  ],{ 'cwd' : 'MusicStore.Web'})
);

gulp.task('test', shell.task([
    'echo "Running Unit Tests..."'
],{ 'cwd' : ''}))

gulp.task('watch', function() {
  var watcher = gulp.watch('MusicStore.Web/**/*.cs',['build'])
  watcher.on('change', function (event) {

  });
});

gulp.task('restore', function(){
  shell.task([
    'echo "Restore NuGet Packages..."',
    'nuget restore'
  ])
});

gulp.task('default', ['watch']);