module.exports = {
  extends: ["@commitlint/config-conventional"], rules: {
    'footer-max-line-length': [0, 'always'] // Make sure there is never a max-line-length by disabling the rule
  },
  parserPreset: {
    parserOpts: {
      noteKeywords: ['link:'] // Create a custom keyword to distinguish the footer
    }
  }
};
