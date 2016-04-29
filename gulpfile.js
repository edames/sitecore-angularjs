var gulp = require('gulp'),
	shell = require('gulp-shell'),
    browserSync = require('browser-sync').create();

gulp.task('build', ['restore'], shell.task([
    'echo "Building Sitecore AngularJS..."',
    'msbuild MusicStore.Web.csproj /p:Configuration=Debug'
  ],{ 'cwd' : 'MusicStore.Web'})
);

gulp.task('deploy', shell.task([
     'echo "Deploying site...', 
     'msbuild site.build' 
   ], { 'cwd' : 'tools'})
);

gulp.task('test', shell.task([
    'echo "Running Unit Tests..."'
],{ 'cwd' : ''}))

gulp.task('watch', function() {
  var watcher = gulp.watch('MusicStore.Web/**/*',['build', 'deploy', 'sync'])
});

gulp.task('restore', function(){
  shell.task([
    'echo "Restore NuGet Packages..."',
    'nuget restore'
  ])
});

gulp.task('copy', function(){
    gulp.src('./node_modules/angular/*.js')
        .pipe(gulp.dest('./MusicStore.Web/js/'));
});

gulp.task('init-browser-sync', function()
{
   browserSync.init({
        proxy:  "localhost:8080"        
    }); 
});

gulp.task('sync', [], function() {
    gulp.watch(["public/**/*", "!public/bin/**/*"], {debounceDelay: 2000}).on('change', browserSync.reload);
    //browserSync.reload();
});

gulp.task('server', shell.task([
    'echo "Start Server..."',
    'start start_website.bat'
]));

gulp.task('default', ['server', 'init-browser-sync', 'watch']);